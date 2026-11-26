using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class TestUserInputs
    {
        static void Main()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Hi {name} your age is {age} and salary is {salary}");

        }
    }
}
