namespace PB503OOP.Model.AnimalTask;

public class Horse : Animal
{
    public int HorseShoeCount { get; set; }

    public Horse(string name, byte age, int horseShoeCount) : base(name, age)
    {
        HorseShoeCount = horseShoeCount;
    }

    public override void Eat()
    {
        Console.WriteLine("Horse eating carrot...");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Horse making noise...");
    }
}
