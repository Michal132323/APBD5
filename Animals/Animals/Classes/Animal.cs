using System.Diagnostics.CodeAnalysis;

namespace Animals.Classes;

public class Animal
{
    private ICollection<Visit> _visits;
    public Animal(string name, string category, int mass, string hairColor)
    {
        Id = maxID++;
        this.name = name;
        this.category = category;
        this.mass = mass;
        this.hairColor = hairColor;
        _visits = new List<Visit>();
    }

    public void AddVisit(string date, string description, int price)
    {
        _visits.Add(new Visit(date,this,description,price));
    }

    public ICollection<Visit> GetVisits()
    {
        return _visits;
    }
    public int Id { get; }
    public string name { get; set; }
    public string category { get; set; }
    public int mass { get; set; }
    public string hairColor { get; set; }
    private static int maxID = 0;
}