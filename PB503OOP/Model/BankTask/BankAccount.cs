namespace PB503OOP.Model.BankTask
{
    public class BankAccount
    {
        private decimal _balance;
        public string AccountNumber { get; set; }
        public decimal Balance
        {
            get => _balance;
            set
            {
                if (value > 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance can not be less than zero!");
                }
            }
        }

        public void Deposit(decimal input)
        {
            Balance += input;
        }

        public void Withdraw(decimal input)
        {
            Balance -= input;
        }
    }
}
