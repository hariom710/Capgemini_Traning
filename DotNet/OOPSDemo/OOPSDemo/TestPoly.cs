using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class TestPoly
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            CalculateArea(shape);
            shape = new Circle { Radius =15};
            CalculateArea(shape);
            shape = new Rectangle { Length=15, Breadth = 15 };
            CalculateArea(shape);
        }

        public static void CalculateArea(Shape shape)
        {
            shape.Area();
        }
    }
}
