using System;

namespace E_Commerce_System
{
    internal class ElectronicsProduct : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.10; // 10%
        }
    }

    internal class ClothingProduct : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.20; // 20%
        }
    }

    internal class GroceryProduct : Product
    {
        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5%
        }
    }
}