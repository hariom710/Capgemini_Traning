using System;
using System.Collections.Generic;
using System.Text;

namespace DAY1_ASSIGNMENT
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public string Display()
        {
            return $"Id: {Id}, Name: {Name}, Marks: {Marks}";
        }
    }

}
