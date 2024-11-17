namespace PB503OOP.Model.VehicleTask;

public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    public Truck(string brand, string model, int year, int payloadCapacity) : base(brand, model, year)
    {
        PayloadCapacity = payloadCapacity;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, PayloadCapacity: {PayloadCapacity}");
    }

}
