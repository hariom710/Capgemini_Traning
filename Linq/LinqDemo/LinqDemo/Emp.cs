using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    internal class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public double Salary { get; set; }

        public List<Emp> EmpList()
        {
            return new List<Emp>()
            {
                new Emp(){Id=1, Name="John", Dept="HR", Salary=50000},
                new Emp(){Id=2, Name="Jane", Dept="IT", Salary=60000},
                new Emp(){Id=3, Name="Bob", Dept="Finance", Salary=55000},
                new Emp(){Id=4, Name="Alice", Dept="IT", Salary=65000},
                new Emp(){Id=5, Name="Tom", Dept="HR", Salary=52000}
            };
        }
    }
}

class Dept
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public List<Dept> DeptList()
    {
        return new List<Dept>()
        {
            new Dept(){Id=1, Name="HR", Location="New York"},
            new Dept(){Id=2, Name="IT", Location="San Francisco"},
            new Dept(){Id=3, Name="Finance", Location="Chicago"}
        };
    }
}
