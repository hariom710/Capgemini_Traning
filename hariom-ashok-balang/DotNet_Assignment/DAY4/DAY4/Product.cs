abstract class Product
{
    public double Price;
    public abstract double CalculateDiscount();
}

class ElectronicsProduct : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }
}

class ClothingProduct : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.20;
    }
}

class GroceryProduct : Product
{
    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
}