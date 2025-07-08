using AbstractFactory.Concrete.Victorian;

namespace AbstractFactory.Abstractions.Factory;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }
}