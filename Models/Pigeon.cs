namespace Models
{
public class Pigeon : Bird
{
    public Pigeon(string name, string color) : base(name, color)
    {
    }

    public void EatPizza() 
    {
        Console.WriteLine("Delicious pizza!");
    }

    public void Sleep() 
    {
        Console.WriteLine("I'm a sleeping pigeon");
    }
}
}
