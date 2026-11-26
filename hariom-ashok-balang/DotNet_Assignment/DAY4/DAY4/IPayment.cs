interface IPayment
{
    void ProcessPayment(double amount);
}

class CreditCardPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using Credit Card");
    }
}

class UPIPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using UPI");
    }
}

class PayPalPayment : IPayment
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal");
    }
}