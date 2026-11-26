using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class TestGenerics
    {
        public static void Main()
        {
            int a = 10, b = 20;
            Console.WriteLine("before swapping: a={0}, b={1}", a, b);
            //Swap(ref a, ref b);
            NewSwap(ref a, ref b);
            Console.WriteLine("after swapping: a={0}, b={1}", a, b);
            string str1 = "Hello", str2 = "World";
            NewSwap(ref str1, ref str2);
            Console.WriteLine("after swapping: str1={0}, str2={1}", str1, str2);
        }

        private static void NewSwap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        //private static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
    }
}
