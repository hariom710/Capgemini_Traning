class CurrentAccount : Account
{
    public override void Deposit(double amt)
    {
        Balance += amt;
        logs.Add("Deposit: " + amt);
    }

    public override void Withdraw(double amt)
    {
        Balance -= amt; // overdraft allowed (simple version)
        logs.Add("Withdraw: " + amt);
    }

    public override double CalculateInterest()
    {
        return Balance * 0.01;
    }
}