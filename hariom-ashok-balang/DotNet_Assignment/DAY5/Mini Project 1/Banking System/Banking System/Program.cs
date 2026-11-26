namespace DAY5_Banking
{
    internal class Program
    {
        static List<Account> accList = new List<Account>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n---- BANK MENU ----");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Interest");
                Console.WriteLine("6. Transactions");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: CreateAcc(); break;
                    case 2: DoDeposit(); break;
                    case 3: DoWithdraw(); break;
                    case 4: ShowBal(); break;
                    case 5: ShowInt(); break;
                    case 6: ShowLogs(); break;
                }

            } while (choice != 0);
        }

        static Account Search(string no)
        {
            foreach (var a in accList)
                if (a.AccountNumber == no)
                    return a;
            return null;
        }

        static void CreateAcc()
        {
            Console.Write("1.Savings  2.Current : ");
            int t = Convert.ToInt32(Console.ReadLine());

            Account ac;
            if (t == 1) ac = new SavingsAccount();
            else ac = new CurrentAccount();

            Console.Write("Account No: ");
            ac.AccountNumber = Console.ReadLine();

            Console.Write("Holder Name: ");
            ac.AccountHolderName = Console.ReadLine();

            Console.Write("Set PIN: ");
            ac.SetPin(Convert.ToInt32(Console.ReadLine()));

            accList.Add(ac);
            Console.WriteLine("Account created.");
        }

        static void DoDeposit()
        {
            Console.Write("Acc No: ");
            var a = Search(Console.ReadLine());
            if (a == null) return;

            Console.Write("Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            a.Deposit(amt);
        }

        static void DoWithdraw()
        {
            Console.Write("Acc No: ");
            var a = Search(Console.ReadLine());
            if (a == null) return;

            Console.Write("Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());
            a.Withdraw(amt);
        }

        static void ShowBal()
        {
            Console.Write("Acc No: ");
            var a = Search(Console.ReadLine());
            if (a != null)
                Console.WriteLine("Balance: " + a.Balance);
        }

        static void ShowInt()
        {
            Console.Write("Acc No: ");
            var a = Search(Console.ReadLine());
            if (a != null)
                Console.WriteLine("Interest: " + a.CalculateInterest());
        }

        static void ShowLogs()
        {
            Console.Write("Acc No: ");
            var a = Search(Console.ReadLine());
            a?.ShowTransactionHistory();
        }
    }
}