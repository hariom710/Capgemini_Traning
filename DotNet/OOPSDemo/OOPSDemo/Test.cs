using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Test
    {
        public static void Main()
        {
            Console.WriteLine($"Total pens are {Pen.ShowCount()}");
            Console.WriteLine(  "this is test class ");
            Pen pen1 = new Pen("Blue" ,10);
            Pen pen2 = new Pen();
            pen2.Cost = 20;
            pen2.Color = "Red";
            Console.WriteLine(pen1.Display());
            Console.WriteLine(pen2.Display());
            pen1.Cost = -50;
            Console.WriteLine(pen1.Display());
            Console.WriteLine($"Total pens are {Pen.ShowCount()}");
            Products p1=new Products() { Id = 1, Name = "Laptop", Price = 10 };
            Products p2 = new Products() { Name = "Mobile", Price = 10 };
            Console.WriteLine($"Product 1: Id={p1.Id}, Name={p1.Name}, Price={p1.Price}");
            Console.WriteLine($"Product 2: Id={p2.Id}, Name={p2.Name}, Price={p2.Price}");




        }
    }
}
