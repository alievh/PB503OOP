using PB503OOP.Interfaces;

namespace PB503OOP.Model.Vehicle2Task;

public class SecondMotorcycle : SecondVehicle, ISound
{
    public string RaceType { get; set; }

    public SecondMotorcycle(string brand, string model, int maxSpeed, string raceType) : base(brand, model, maxSpeed)
    {
        RaceType = raceType;
    }

    public override void Drive()
    {
        Console.WriteLine("Motorcycle start to go..");
    }

    public void MakeSound()
    {
        Console.WriteLine("Vin-vin");
    }
}
