using AbstractFactory.Abstractions;

namespace AbstractFactory.Concrete.Victorian;

public class VictorianChair : IChair
{
    public int GetLegs()
    {
        return 4; // Victorian chairs typically have four legs.
    }

    public string GetStyle()
    {
        return "Victorian"; // The style of the chair.
    }

    public void Sit()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}