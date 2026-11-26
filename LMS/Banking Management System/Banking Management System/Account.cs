using System;

namespace Banking_Management_System
{
    public abstract class Account
    {
        public int AccountNumber { get; protected set; }
        public string AccountHolderName { get; protected set; }
        public decimal Balance { get; protected set; }

        public Account(int accountNumber, string accountHolderName, decimal initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountHolderName))
                throw new ArgumentException("Account Holder Name cannot be empty.");
            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative.");

            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than zero.");
            Balance += amount;
        }

        public abstract void Withdraw(decimal amount);

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Acc No: {AccountNumber} | Name: {AccountHolderName} | Balance: ₹{Balance}");
        }
    }
}
