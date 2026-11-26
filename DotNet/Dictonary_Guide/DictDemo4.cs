using System;
using System.Collections.Generic;
namespace Dictonary_Guide
{
    internal class DictDemo4
    {
        public static void Run()
        {
            var emplist=new List<Employee>
            {
                new Employee("Alice", 30, "HR"),
                new Employee("Bob", 25, "IT"),
                new Employee("Charlie", 28, "Finance")
            };
            var data=new Dictionary<string, List<Employee>>();
            foreach(var emp in emplist)
            {
                if(!data.ContainsKey(emp.Department))
                {
                    data[emp.Department]=new List<Employee>();
                }
                data[emp.Department].Add(emp);
            }
             foreach(var pair in data)
             {
                Console.WriteLine($"Department: {pair.Key}");
                foreach(var emp in pair.Value)
                {
                    Console.WriteLine($" - {emp.Name}, Age: {emp.Age}");
                }
             }
        }
    }
}