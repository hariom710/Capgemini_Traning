namespace MTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter shape (rectangle/square/circle): ");
            string? type = Console.ReadLine()?.ToLower();
            Shape? shape = null;
            if (type == "rectangle")
            {
                Console.Write("Enter length: ");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter breadth: ");
                double b = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle { Length = l, Breadth = b };
            }
            else if (type == "square")
            {
                Console.Write("Enter side: ");
                double s = Convert.ToDouble(Console.ReadLine());

                shape = new Square { Side = s };
            }
            else if (type == "circle")
            {
                Console.Write("Enter radius: ");
                double r = Convert.ToDouble(Console.ReadLine());

                shape = new Circle { Radius = r };
            }
            else
            {
                Console.WriteLine("Invalid shape type.");
                return;
            }
            Console.WriteLine($"Area      : {shape.CalculateArea()}");
            Console.WriteLine($"Perimeter : {shape.CalculatePerimeter()}");
        }
    }

}
