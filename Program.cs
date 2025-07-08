using AbstractFactory.Abstractions.Factory;

namespace AbstractFactory;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a modern furniture factory
        IFurnitureFactory modernFactory = new ModernFurnitureFactory();

        ClientMethod(modernFactory);

        // Create a Victorian furniture factory
        IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();

        ClientMethod(victorianFactory);
    }

    private static void ClientMethod(IFurnitureFactory factory)
    {
        var chair = factory.CreateChair();
        var table = factory.CreateTable();

        Console.WriteLine($"Chair is: {chair.GetStyle()}");
        chair.Sit();
        Console.WriteLine($"Chair has {chair.GetLegs()} legs.");

        Console.WriteLine($"Table is: {table.GetStyle()}");
        table.PlaceItems();
    }
}