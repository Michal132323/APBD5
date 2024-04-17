using Animals.Classes;

namespace Animals.MockDB;

public interface IMockDB
{
    public ICollection<Animal> GetALL();
    public Animal GetAnimal(int id);

    public bool AddAnimal(Animal animal);
    public bool ChangeAnimal(Animal animal,int id);
    public bool Delete(int id);
    public ICollection<Visit> GetVisits(int id);
    public bool AddVisit(int id,string date , string description,int price);

}