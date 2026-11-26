using System;
using System.Collections.Generic;

namespace E_Commerce_System
{
    internal class Program
    {
        static List<Product> prodList = new List<Product>();
        static Cart cart = new Cart();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n----- E-Commerce Menu -----");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Products");
                Console.WriteLine("3. Add to Cart");
                Console.WriteLine("4. Calculate Final Price");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddProduct(); break;
                    case 2: ViewProducts(); break;
                    case 3: AddProductToCart(); break;
                    case 4: cart.Checkout(); break;
                }

            } while (choice != 0);
        }

        static void AddProduct()
        {
            Console.Write("1.Electronics  2.Clothing  3.Grocery : ");
            int type = Convert.ToInt32(Console.ReadLine());

            Product p;

            if (type == 1) p = new ElectronicsProduct();
            else if (type == 2) p = new ClothingProduct();
            else p = new GroceryProduct();

            Console.Write("Product Id: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            p.Name = Console.ReadLine();

            Console.Write("Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            prodList.Add(p);
            Console.WriteLine("Product added successfully.");
        }

        static void ViewProducts()
        {
            if (prodList.Count == 0)
            {
                Console.WriteLine("No products available.");
                return;
            }

            // polymorphism display
            foreach (var p in prodList)
                p.Display();
        }

        static void AddProductToCart()
        {
            Console.Write("Enter Product Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var p in prodList)
            {
                if (p.ProductId == id)
                {
                    cart.AddToCart(p);
                    return;
                }
            }

            Console.WriteLine("Product not found.");
        }
    }
}