using System;

namespace Banking_Management_System
{
    public class SavingsAccount : Account
    {
        private const decimal MinimumBalance = 500m;

        public SavingsAccount(int accountNumber, string accountHolderName, decimal initialBalance) 
            : base(accountNumber, accountHolderName, initialBalance)
        {
            if (initialBalance < MinimumBalance)
                throw new ArgumentException($"Savings account must be created with a minimum balance of ₹{MinimumBalance}.");
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be greater than zero.");
            
            if (Balance - amount < MinimumBalance)
                throw new InvalidOperationException($"Insufficient balance. Minimum balance of ₹{MinimumBalance} must be maintained.");

            Balance -= amount;
        }
    }
}
