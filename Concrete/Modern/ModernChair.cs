using AbstractFactory.Abstractions;

namespace AbstractFactory.Concrete.Modern;

public class ModernChair : IChair
{
    public int GetLegs()
    {
        return 0; // Modern chairs can have a variable number of legs, here we return 0 for simplicity.
    }

    public string GetStyle()
    {
        return "Modern"; // The style of the chair.
    }

    public void Sit()
    {
        Console.WriteLine("Sitting on a Modern chair.");
    }
}