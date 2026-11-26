using System;
using System.Collections.Generic;

namespace E_Commerce_System
{
    internal class Cart : ICart
    {
        private List<Product> cartItems = new List<Product>();

        public void AddToCart(Product p)
        {
            cartItems.Add(p);
            Console.WriteLine("Item added to cart.");
        }

        public void RemoveFromCart(Product p)
        {
            cartItems.Remove(p);
            Console.WriteLine("Item removed from cart.");
        }

        public void Checkout()
        {
            if (cartItems.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }

            double total = 0;

            // polymorphism in action
            foreach (var item in cartItems)
            {
                double discount = item.CalculateDiscount();
                total += (item.Price - discount);
            }

            double gst = total * 0.18; // bonus feature
            double finalAmount = total + gst;

            Console.WriteLine("Amount after discount : " + total);
            Console.WriteLine("GST (18%)             : " + gst);
            Console.WriteLine("Final Payable         : " + finalAmount);
        }
    }
}