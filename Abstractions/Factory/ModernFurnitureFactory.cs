using AbstractFactory.Concrete.Modern;

namespace AbstractFactory.Abstractions.Factory;

public class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ITable CreateTable()
    {
        return new ModernTable();
    }
}