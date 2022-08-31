namespace Models
{
public class Parrot : Bird
{
    public Parrot(string name, string color) : base(name, color)
    {
    }

    public override void Speak() 
    {
        Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} parrot and I'm going to repeat everything after you, so think carefully about your words!");
    }

}
}
