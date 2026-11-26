using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal class TestInheritance
    {
        static void Main()
        {
            Manager m1 = new Manager
            { DA = 1000, HRA = 5000, Id = 101, Name = "Ravi", Salary = 20000, Dept = "IT" };

            Console.WriteLine(m1.showdetails());
        }
    }
}
