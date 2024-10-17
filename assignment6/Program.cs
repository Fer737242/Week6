using System;

namespace AccessModifiersDemo
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
            // Create an account object with a predefined holder name
            Account account = new Account("HOlder");

            Console.Write("Enter deposit amount: ");
            double depositAmount = double.Parse(Console.ReadLine());

            // Deposit funds...?
            account.Deposit(depositAmount);
        }
        private class Account
        {
            private string _accountHolder; 
            private double _amount;

            // Constructor to initialize the account holder's name
            public Account(string accountHolder)
            {
                _accountHolder = accountHolder;
                _amount = 0;
            }

            // Method to deposit funds
            public void Deposit(double amount)
            {
                _amount += amount; // Update the balance
                LogTransaction($"Deposited: {amount}"); // Log the transaction...?
                Console.WriteLine("Deposit successful."); 
            }

            // Private method for logging transactions...?
            private void LogTransaction(string message)
            {
            }
        }
    }
}
