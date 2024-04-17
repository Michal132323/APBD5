namespace Animals.Classes;

public class Visit
{
    public Visit(string date, Animal animal, string description, int price)
    {
        Date = date;
        Animal = animal;
        Description = description;
        Price = price;
    }

    public string Date { get; set; }
    public Animal Animal { get;}
    public string Description { get; set; }
    public int Price { get; set; }
}