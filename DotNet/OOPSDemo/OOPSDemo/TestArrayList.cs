using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPSDemo
{
    internal class TestArrayList
    {
        static void Main()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("Harry");
            list.Add(3.14);

            list.Add(new Products() { Id = 101, Name = "Laptop", Price = 120000 });
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is int)
                {
                    int x = Convert.ToInt32(list[i]);
                    Console.WriteLine($" Integer : {x}");

                }
                else if (list[i] is string)
                {
                    string name = list[i].ToString();
                    Console.WriteLine($" Hi {name}");

                }
                else if (list[i] is double)
                {
                    double d = (double)list[i];
                    Console.WriteLine($"Value of d is {d}");
                }
                else if (list[i] is Products)
                {
                    Products p = list[i] as Products;
                    Console.WriteLine($"Id: {p.Id} Name: {p.Name} Price: {p.Price}");
                }
            }
        }
    }
}
