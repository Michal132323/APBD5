using System.ComponentModel.DataAnnotations;
using Animals.Classes;

namespace Animals.MockDB;

public class MockDb : IMockDB
{
    private ICollection<Animal> _animals;

    public MockDb()
    {
        _animals = new List<Animal>()
        {
            new Animal("Max", "Dog", 20, "Red"),
            new Animal("Stefan", "Cat", 8, "Brown"),
            new Animal("Jan", "Horse", 2000, "Blue")
        };
        
        (_animals as List<Animal>)[0].AddVisit("12.02.22","Max ate excessive amounts of IT homework and is now sick to the stomach",20000);
        (_animals as List<Animal>)[0].AddVisit("13.02.22","Max ate the whole computer",9000);
        (_animals as List<Animal>)[1].AddVisit("10.04.24","Stefan has issues pooing in the litter box",200);
        (_animals as List<Animal>)[2].AddVisit("11.12.1965","Jan is blue nobody has figured out why",0);

    }

    public ICollection<Animal> GetALL()
    {
        return _animals;
    }

    public Animal GetAnimal(int id)
    {
        return (_animals as List<Animal>)[id];
    }

    public bool AddAnimal(Animal animal)
    {
        _animals.Add(animal);
        return true;
    }

    public bool ChangeAnimal(Animal animal,int id)
    {
        var replacedAnimal = _animals.FirstOrDefault(e => e.Id == id);
        if (replacedAnimal==null)
        {
            _animals.Add(animal);
            return false;
        }
        replacedAnimal = animal;
        return true;
    }

    public bool Delete(int id)
    {
        _animals.Remove(_animals.FirstOrDefault(e => e.Id == id));
        return true;
    }

    public ICollection<Visit> GetVisits(int id)
    {
        return (_animals as List<Animal>)[id].GetVisits();
    }

    public bool AddVisit(int id,string date , string description,int price)
    {
        (_animals as List<Animal>)[id].AddVisit(date ,  description, price);
        return true;
    }
}