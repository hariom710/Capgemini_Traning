using System;
using System.Collections.Generic;

namespace Dictonary_Guide
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, string department)
        {
            Name = name;
            Age = age;
            Department = department;
        }

        
    }
}