using PB503OOP.Interfaces;

namespace PB503OOP.Model.Vehicle2Task
{
    public class SecondTrain : SecondVehicle, ISound
    {
        private int _carriageCount;

        public int CarriageCount
        {
            get => _carriageCount;
            set
            {
                if (value >= 1)
                {
                    _carriageCount = value;
                }
                else
                {
                    Console.WriteLine("Carriage count can not be less than one...");
                }

            }
        }

        public SecondTrain(string brand, string model, int maxSpeed, int carriageCount) : base(brand, model, maxSpeed)
        {
            CarriageCount = carriageCount;
        }

        public override void Drive()
        {
            Console.WriteLine("Train start to go...");
        }

        public void MakeSound()
        {
            Console.WriteLine("Tuf-tuf");
        }
    }
}
