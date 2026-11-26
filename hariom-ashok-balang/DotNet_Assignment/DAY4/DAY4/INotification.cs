interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email: " + message);
    }
}

class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS: " + message);
    }
}

class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Push: " + message);
    }
}