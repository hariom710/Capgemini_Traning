abstract class Account : ITransaction
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; protected set; }

    private int _pin;
    protected List<string> logs = new List<string>();

    public void SetPin(int p)
    {
        _pin = p;
    }

    public bool CheckPin(int p)
    {
        return _pin == p;
    }

    public abstract void Deposit(double amt);
    public abstract void Withdraw(double amt);
    public abstract double CalculateInterest();

    public void ShowTransactionHistory()
    {
        if (logs.Count == 0)
        {
            Console.WriteLine("No transactions yet.");
            return;
        }

        foreach (string s in logs)
            Console.WriteLine(s);
    }
}