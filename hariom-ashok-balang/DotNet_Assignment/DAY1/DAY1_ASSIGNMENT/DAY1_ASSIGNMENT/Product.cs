using System;

namespace DAY1_ASSIGNMENT
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public void AddStock(int qty)
        {
            if (qty > 0)
            {
                Quantity += qty;
                Console.WriteLine($"{qty} items added.");
            }
            else
            {
                Console.WriteLine("Invalid quantity.");
            }
        }

        public void SellProduct(int qty)
        {
            if (qty <= 0)
            {
                Console.WriteLine("Invalid quantity.");
                return;
            }

            if (qty <= Quantity)
            {
                Quantity -= qty;
                Console.WriteLine($"{qty} items sold.");
            }
            else
            {
                Console.WriteLine("Not enough stock available.");
            }
        }

        public void ShowProductDetails()
        {
            Console.WriteLine($"Product ID : {ProductId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Price      : {Price}");
            Console.WriteLine($"Quantity   : {Quantity}");
        }
    }
}
