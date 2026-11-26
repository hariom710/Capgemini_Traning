using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSDemo
{
    internal class TestException
    {
        static void Main()
        {
            int a = 10, b = 50;
            try
            {
                if (a > b) {
                    int c = a / b;
                    Console.WriteLine($"Result is {c}");
                } else { 
                    throw new MyException("a should be greater than b!!!");
                }
                
                int[] arr = new int[5];
                arr[9] = 100;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero!!!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some error occurred!!!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This block will always execute!!!");
            }
        }
    }
}
