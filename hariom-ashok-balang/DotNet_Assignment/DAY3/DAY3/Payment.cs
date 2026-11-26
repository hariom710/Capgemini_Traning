class Payment
{
    public virtual void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing payment");
    }
}

class CreditCardPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Paid " + amount + " using Credit Card");
    }
}

class UPIPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Paid " + amount + " using UPI");
    }
}

class PayPalPayment : Payment
{
    public override void ProcessPayment(double amount)
    {
        Console.WriteLine("Paid " + amount + " using PayPal");
    }
}