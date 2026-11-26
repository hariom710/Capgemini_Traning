using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    abstract internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }

        public string Showdetails()
        {
            return $" ID: {Id} \n Name: {Name} \n Dept: {Dept} \n Salary: {Salary}";
        }
        public abstract double CalcSalary();


    }
}
