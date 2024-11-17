namespace PB503OOP.Model.AnimalTask;

public class Leon : Animal
{
    public bool IsKing { get; set; }

    public Leon(string name, byte age, bool isKing) : base(name, age)
    {
        IsKing = isKing;
    }

    public override void Eat()
    {
        Console.WriteLine("Leon eating meat...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Leon making noise...");
    }
}
