using System;
namespace DAY2
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        public double Length
        {
            get { return _length; }
            set
            {
                if (value > 0)
                    _length = value;
                else
                    Console.WriteLine("Length must be greater than 0.");
            }
        }
        public double Width
        {
            get { return _width; }
            set
            {
                if (value > 0)
                    _width = value;
                else
                    Console.WriteLine("Width must be greater than 0.");
            }
        }
        public double CalculateArea()
        {
            return _length * _width;
        }
    }
}