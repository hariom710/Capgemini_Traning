using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking_Management_System
{
    public class BankManager
    {
        private List<Account> _accounts = new List<Account>();
        private int _nextAccountNumber = 1001;

        public void CreateAccount(int type, string name, decimal initialBalance)
        {
            Account newAccount;
            if (type == 1)
            {
                newAccount = new SavingsAccount(_nextAccountNumber++, name, initialBalance);
            }
            else if (type == 2)
            {
                newAccount = new CurrentAccount(_nextAccountNumber++, name, initialBalance);
            }
            else
            {
                throw new ArgumentException("Invalid account type.");
            }

            _accounts.Add(newAccount);
            Console.WriteLine($"Account successfully created! Account Number: {newAccount.AccountNumber}");
        }

        public Account GetAccount(int accountNumber)
        {
            var account = _accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account == null)
            {
                throw new KeyNotFoundException("Account not found.");
            }
            return account;
        }

        public void Deposit(int accountNumber, decimal amount)
        {
            var account = GetAccount(accountNumber);
            account.Deposit(amount);
            Console.WriteLine($"Successfully deposited ₹{amount}. New Balance: ₹{account.Balance}");
        }

        public void Withdraw(int accountNumber, decimal amount)
        {
            var account = GetAccount(accountNumber);
            account.Withdraw(amount);
            Console.WriteLine($"Successfully withdrew ₹{amount}. New Balance: ₹{account.Balance}");
        }

        public void CheckBalance(int accountNumber)
        {
            var account = GetAccount(accountNumber);
            Console.WriteLine($"Current Balance for Account {accountNumber}: ₹{account.Balance}");
        }

        public void ViewAllAccounts()
        {
            if (_accounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }

            Console.WriteLine("--- All Accounts ---");
            foreach (var account in _accounts)
            {
                account.DisplayDetails();
            }
        }
    }
}
