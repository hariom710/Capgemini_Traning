class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Vehicle engine started");
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started");
    }
}

class Bike : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started");
    }
}

class Truck : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Truck engine started");
    }
}