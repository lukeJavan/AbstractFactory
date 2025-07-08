using AbstractFactory.Abstractions;

namespace AbstractFactory.Concrete.Modern;

public class ModernTable : ITable
{
    public string GetStyle()
    {
        return "Modern";
    }

    public void PlaceItems()
    {
        Console.WriteLine("Placing items on a Modern table.");
    }
}