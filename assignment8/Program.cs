namespace assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            BankAccount account = new BankAccount("123456", 0);

            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());
            account.Deposit(depositAmount);
            Console.WriteLine();
            Console.Write("Enter withdrawal amount: ");
            double withdrawalAmount = double.Parse(Console.ReadLine());
            account.Withdraw(withdrawalAmount);
            Console.WriteLine();
            Console.WriteLine("Account details: ");
            Console.WriteLine($"Account number {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");
        }
        private class BankAccount
        {
            //these are properties
            public string AccountNumber { get; private set; }
            public double Balance { get; private set; }

            //this is the constructor
            public BankAccount(string accountNumber, double initialBalance)
            {
                AccountNumber = accountNumber;
                Balance = initialBalance;
            }
            //method to deposit funds
            public void Deposit(double amount)
            {
                Balance += amount;
                Console.WriteLine("Deposit succesful.");
            }
            //method for withdraw
            public void Withdraw(double amount)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdrawal succesful.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Go to work.");
                }
            }
        }
    }
}