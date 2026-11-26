using System;
namespace DAY2
{
    internal class Employee
    {
        private int _empId;
        private string _name;
        private decimal _salary;
        public int EmpId
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                if (value > 0)
                    _salary = value;
                else
                    Console.WriteLine("Salary must be greater than 0.");
            }
        }
    }
}