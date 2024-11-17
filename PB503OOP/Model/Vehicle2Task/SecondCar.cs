using PB503OOP.Interfaces;

namespace PB503OOP.Model.Vehicle2Task
{
    public class SecondCar : SecondVehicle, ISound
    {
        public string FuelType { get; set; }

        public SecondCar(string brand, string model, int maxSpeed, string fuelType) : base(brand, model, maxSpeed)
        {
            FuelType = fuelType;
        }

        public override void Drive()
        {
            Console.WriteLine("Car start to go...");
        }

        public void MakeSound()
        {
            Console.WriteLine("Bip-bip");
        }
    }
}
