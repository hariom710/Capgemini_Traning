using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class Pen
    {
        private static int count;
        public static int ShowCount()
        {
            return count;
        }
        private string color;
        private int cost;
        public string Color
        {
            get { return color; } 
            set { color = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { 
                if (value > 0)
                {
                    cost = value; 
                }
            }
        }
        public Pen() { count++; }
        public Pen(string color, int cost)
        {
            this.color = color;
            this.cost = cost;
            count++;
        }
        public string Display()
        {
            string details = $"Pen color: {color}, Pen cost: {cost}";
            return details;
        }
        static Pen()
        {
            Console.WriteLine(" in Static constructor ");
        }
    }
}
