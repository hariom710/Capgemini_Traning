using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    static internal class MyExt
    {
        public static int MyWordCount(this string s)
        {
            int count = s.Split(' ').Count();
            return count;
        }

        public static string OddEven(this int n)
        {
            if (n % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
        public static int Discount(this Products products, int percentage)
        {
            int discountAmount = (int)(products.Price * percentage / 100);
            return discountAmount;

        }

        public static void Display(string name, int age, string city ="Nagpur")
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }
    }
}
