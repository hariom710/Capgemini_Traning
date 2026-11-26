using System;

namespace Banking_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankManager manager = new BankManager();
            while (true)
            {
                Console.WriteLine("\n--- Banking Management System ---");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. View All Accounts");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            Console.WriteLine("Select Account Type: 1. Savings 2. Current");
                            Console.Write("Choice: ");
                            if (!int.TryParse(Console.ReadLine(), out int type) || (type != 1 && type != 2))
                                throw new ArgumentException("Invalid account type selected.");

                            Console.Write("Enter Account Holder Name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter Initial Balance: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal initialBalance))
                                throw new FormatException("Invalid balance format.");

                            manager.CreateAccount(type, name, initialBalance);
                            break;

                        case "2":
                            Console.Write("Enter Account Number: ");
                            if (!int.TryParse(Console.ReadLine(), out int depAcc))
                                throw new FormatException("Invalid account number format.");

                            Console.Write("Enter Deposit Amount: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal depAmt))
                                throw new FormatException("Invalid amount format.");

                            manager.Deposit(depAcc, depAmt);
                            break;

                        case "3":
                            Console.Write("Enter Account Number: ");
                            if (!int.TryParse(Console.ReadLine(), out int withAcc))
                                throw new FormatException("Invalid account number format.");

                            Console.Write("Enter Withdrawal Amount: ");
                            if (!decimal.TryParse(Console.ReadLine(), out decimal withAmt))
                                throw new FormatException("Invalid amount format.");

                            manager.Withdraw(withAcc, withAmt);
                            break;

                        case "4":
                            Console.Write("Enter Account Number: ");
                            if (!int.TryParse(Console.ReadLine(), out int balAcc))
                                throw new FormatException("Invalid account number format.");

                            manager.CheckBalance(balAcc);
                            break;

                        case "5":
                            manager.ViewAllAccounts();
                            break;

                        case "6":
                            Console.WriteLine("Exiting... Good bye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
