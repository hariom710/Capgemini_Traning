class SavingsAccount : Account
{
    public override void Deposit(double amt)
    {
        if (amt <= 0) return;

        Balance += amt;
        logs.Add("Deposit: " + amt);
    }

    public override void Withdraw(double amt)
    {
        if (amt > Balance)
        {
            Console.WriteLine("Low balance");
            return;
        }

        Balance -= amt;
        logs.Add("Withdraw: " + amt);
    }

    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }
}