namespace AbstractFactory.Abstractions
{
    public interface IChair
    {
        int GetLegs();

        string GetStyle();
        
        void Sit();
    }
}