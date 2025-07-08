namespace AbstractFactory.Abstractions.Factory;

public interface IFurnitureFactory
{
    IChair CreateChair();

    ITable CreateTable();
}
