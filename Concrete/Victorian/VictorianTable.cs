using AbstractFactory.Abstractions;

namespace AbstractFactory.Concrete.Victorian;

public class VictorianTable : ITable
{
    public string GetStyle()
    {
        return "Victorian"; // The style of the table.
    }

    public void PlaceItems()
    {
        Console.WriteLine("Placing items on a Victorian table.");
    }
}