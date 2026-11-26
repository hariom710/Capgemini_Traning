using System;

namespace E_Commerce_System
{
    internal abstract class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract double CalculateDiscount();

        public virtual void Display()
        {
            Console.WriteLine($"{ProductId}  {Name}  Rs.{Price}");
        }
    }
}