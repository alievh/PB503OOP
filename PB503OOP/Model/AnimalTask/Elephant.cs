namespace PB503OOP.Model.AnimalTask;

public class Elephant : Animal
{
    public int Speed { get; set; }

    public Elephant(string name, byte age, int speed) : base(name, age)
    {
        Speed = speed;
    }

    public override void Eat()
    {
        Console.WriteLine("Elephant eating grass...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Elephant making noise..");
    }
}
