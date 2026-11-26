using System;

namespace Banking_Management_System
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int accountNumber, string accountHolderName, decimal initialBalance) 
            : base(accountNumber, accountHolderName, initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            
            // Overdraft allowed, so balance can go negative.
            Balance -= amount;
        }
    }
}
