using OOPSDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class TestList
    {
        public static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            List<Products> plist = new List<Products>() {

            new Products { Id = 1, Name = "Laptop", Price = 50000 },
            new Products { Id = 2, Name = "Mobile", Price = 20000 },
            new Products { Id = 3, Name = "Tablet", Price = 30000 }
                };

            plist.Sort();
            foreach (Products p in plist)
            {
                Console.WriteLine(p);
                Console.WriteLine($"Id: {p.Id} Name: {p.Name} Price: {p.Price}");
            }

            double totalPrice = plist.Sum(p => p.Price);
            Console.WriteLine($"Total Price is {totalPrice}");
            double maxPrice = plist.Max(p => p.Price);
            Console.WriteLine($"Max Price is {maxPrice}");
            double minPrice = plist.Min(p => p.Price);
            Console.WriteLine($"Min Price is {minPrice}");

            var expensiveproduct = plist.Where(p => p.Price > 2000);
            foreach (Products p in expensiveproduct)
            {
                Console.WriteLine($"Id: {p.Id} Name: {p.Name} Price: {p.Price}");
            }


            //for (int i=0;i<list.Count;i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
        }
    }
}
