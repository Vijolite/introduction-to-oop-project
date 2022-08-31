namespace Models
{
public abstract class Bird
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public Bird(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public abstract void Speak();

    public virtual void Fly() 
    {
        Console.WriteLine("Hi there! I can fly.");
    }
}
}
