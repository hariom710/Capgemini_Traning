class BankAccount
{
    public double Balance;

    public virtual double CalculateInterest()
    {
        return 0;
    }
}

class SavingsAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return Balance * 0.04;
    }
}

class CurrentAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return 0;
    }
}

class FixedDepositAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return Balance * 0.07;
    }
}