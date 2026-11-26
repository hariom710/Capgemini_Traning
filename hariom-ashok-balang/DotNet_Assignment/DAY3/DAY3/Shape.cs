abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius;

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length;
    public double Width;

    public override double CalculateArea()
    {
        return Length * Width;
    }
}

class Triangle : Shape
{
    public double Base;
    public double Height;

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }
}