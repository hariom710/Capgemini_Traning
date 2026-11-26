interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}

class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Push notification: " + message);
    }
}