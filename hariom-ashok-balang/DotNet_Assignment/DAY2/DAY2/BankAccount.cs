using System;
namespace DAY2
{
    internal class BankAccount
    {
        private decimal _balance;
        public decimal Balance
        {
            get { return _balance; }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                _balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && _balance - amount >= 0)
                _balance -= amount;
            else
                Console.WriteLine("Insufficient balance.");
        }
    }
}