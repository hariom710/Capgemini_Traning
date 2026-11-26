namespace Calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Add2Numbers(5, 10));
        }

        public static int Add2Numbers(int a, int b)
        {
            return a + b;
        }
    }
}