namespace PB503OOP.Model.AnimalTask
{
    public abstract class Animal
    {
        private byte _age;

        public string Name { get; set; }
        public byte Age
        {
            get => _age; set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age can not be less than zero!");
                }
            }
        }

        protected Animal(string name, byte age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Eat();

        public abstract void MakeSound();
    }
}
