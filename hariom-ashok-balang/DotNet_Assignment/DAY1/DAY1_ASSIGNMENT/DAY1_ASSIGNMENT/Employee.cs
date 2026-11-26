using System;

namespace DAY1_ASSIGNMENT
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public decimal BasicSalary { get; set; }

        public decimal CalculateTotalSalary()
        {
            decimal hra = BasicSalary * 0.10m;
            decimal da = BasicSalary * 0.05m;
            decimal tax = BasicSalary * 0.02m;

            decimal totalSalary = BasicSalary + hra + da - tax;

            return totalSalary;
        }
    }
}
