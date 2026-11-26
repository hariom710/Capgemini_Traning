using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("Area of shape");
        }
    }

    class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Area()
        {
            float area = (float)(Math.PI * Radius * Radius);
            Console.WriteLine($"Area of Circle is {area}");
        }
    }

    class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override void Area()
        {
            int area = Length * Breadth;
            Console.WriteLine($"Area of Rectangle is {area}");
        }
    }
}
