namespace PB503OOP.Model.Vehicle2Task;

public abstract class SecondVehicle
{
    private int _maxSpeed;

    public string Brand { get; }
    public string Model { get; }
    public int MaxSpeed
    {
        get => _maxSpeed;

        set
        {
            if (value > 0)
            {
                _maxSpeed = value;
            }
            else
            {
                Console.WriteLine("Max speed can not be less than zero...");
            }
        }
    }

    public SecondVehicle(string brand, string model, int maxSpeed)
    {
        Brand = brand;
        Model = model;
        MaxSpeed = maxSpeed;
    }

    public abstract void Drive();

}
