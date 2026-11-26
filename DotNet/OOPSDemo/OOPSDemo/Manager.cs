using OOPSDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPsDemo
{
    sealed internal class Manager : Employee
    {
        public int DA { get; set; }
        public int HRA { get; set; }

        public override double CalcSalary()
        {
            
            int totalSalary = (int)(Salary + DA + HRA); 
            return totalSalary;
        }

        public string showdetails()
        {
            return $"Id: {Id}, Name: {Name}, Dept: {Dept}, Salary: {Salary}, DA: {DA}, HRA: {HRA} TotalSalary {CalcSalary()}";
        }
    }

    //class AstManager : Employee
    //{

    //}
}
