namespace PB503OOP.Model.VehicleTask
{
    public class Car : Vehicle
    {
        public byte NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, byte numberOfDoors) : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}, NumberOfDoors: {NumberOfDoors}");
        }
    }
}
