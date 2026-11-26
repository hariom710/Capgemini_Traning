using System;
namespace DAY2
{
    internal class Student
    {
        private int _id;
        private string _name;
        private int _marks;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Marks
        {
            get { return _marks; }
            set
            {
                if (value >= 0 && value <= 100)
                    _marks = value;
                else
                    Console.WriteLine("Marks must be between 0 and 100.");
            }
        }
        public string Display()
        {
            return $"Id: {Id}, Name: {Name}, Marks: {Marks}";
        }
    }
}