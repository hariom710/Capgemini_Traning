interface IPrinter
{
    void Print();
}

class LaserPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Laser printer printing");
    }
}

class InkjetPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Inkjet printer printing");
    }
}

class DotMatrixPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("DotMatrix printer printing");
    }
}