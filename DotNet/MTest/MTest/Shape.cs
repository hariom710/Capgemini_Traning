using System;
using System.Collections.Generic;
using System.Text;

namespace MTest
{
    internal abstract class Shape
    {
        abstract public double CalculateArea();
        abstract public double CalculatePerimeter();
    }
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public override double CalculateArea()
        {
            return Length * Breadth;
        }
        public override double CalculatePerimeter()
        {
            return 2 * (Length + Breadth);
        }
    }
    internal class Square : Shape
    {
        public double Side { get; set; }
        public override double CalculateArea()
        {
            return Side * Side;
        }
        public override double CalculatePerimeter()
        {
            return 4 * Side;
        }
    }
    internal class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

