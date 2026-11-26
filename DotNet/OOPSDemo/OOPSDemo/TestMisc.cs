using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class TestMisc
    {
        static void Main(string[] args)
        {
            var Person = new { Name = "Ravi", Age = 30 };
            Console.WriteLine($"Name: {Person.Name}, Age: {Person.Age}");
            string msg = "TOday is friday";
            msg.MyWordCount();
            Console.WriteLine($"count = {msg.MyWordCount()}");
            int x = 78;
            Console.WriteLine($"Is {x} even? {x.OddEven()}");

            Products p1 = new Products { Id = 101, Name = "Laptop", Price = 50000 };
            Console.WriteLine($"Discount={p1.Discount(5)}");

            string name = "Hariom";int age = 25;string city = "Kupti";
            var person = new { Name = name, Age = age, City = city };

            MyExt.Display(name, age, city);
            MyExt.Display(name, age);

            MyExt.Display(age: age, name: name, city: city);
            MyExt.Display(age: age, name: name);


        }
    }
}
