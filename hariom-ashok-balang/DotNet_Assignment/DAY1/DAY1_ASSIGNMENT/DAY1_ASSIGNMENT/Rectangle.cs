using System;

namespace DAY1_ASSIGNMENT
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
