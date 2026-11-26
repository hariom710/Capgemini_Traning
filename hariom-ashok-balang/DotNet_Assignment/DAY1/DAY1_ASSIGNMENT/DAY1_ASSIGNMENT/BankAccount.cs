using System;

namespace DAY1_ASSIGNMENT
{
    internal class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Current Balance: {Balance}");
        }
    }
}
