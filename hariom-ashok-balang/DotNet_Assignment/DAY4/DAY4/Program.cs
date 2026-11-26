using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace DAY4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAY4 OOP Practice");

            // ✅ Problem 1
            Shape s;
            s = new Circle(); s.Draw();
            s = new Rectangle(); s.Draw();
            s = new Triangle(); s.Draw();

            // ✅ Problem 2
            Animal a;
            a = new Dog(); a.MakeSound();
            a = new Cat(); a.MakeSound();
            a = new Cow(); a.MakeSound();

            // ✅ Problem 3
            IPayment pay;
            pay = new CreditCardPayment(); pay.ProcessPayment(1000);
            pay = new UPIPayment(); pay.ProcessPayment(500);
            pay = new PayPalPayment(); pay.ProcessPayment(750);

            // ✅ Problem 4
            INotification n;
            n = new EmailNotification(); n.Send("Hello Email");
            n = new SMSNotification(); n.Send("Hello SMS");
            n = new PushNotification(); n.Send("Hello Push");

            // ✅ Problem 5
            Vehicle v;
            v = new Car(); v.StartEngine();
            v = new Bike(); v.StartEngine();
            v = new Truck(); v.StartEngine();

            // ✅ Problem 6
            Employee e;
            e = new FullTimeEmployee { BasicSalary = 50000 };
            Console.WriteLine(e.CalculateSalary());
            e = new PartTimeEmployee { BasicSalary = 20000 };
            Console.WriteLine(e.CalculateSalary());
            e = new ContractEmployee { BasicSalary = 30000 };
            Console.WriteLine(e.CalculateSalary());

            // ✅ Problem 7
            MediaFile mf;
            mf = new AudioFile(); mf.Play();
            mf = new VideoFile(); mf.Play();
            mf = new ImageFile(); mf.Play();

            // ✅ Problem 8
            IPrinter p;
            p = new LaserPrinter(); p.Print();
            p = new InkjetPrinter(); p.Print();
            p = new DotMatrixPrinter(); p.Print();

            // ✅ Problem 9
            Product pr;
            pr = new ElectronicsProduct { Price = 10000 };
            Console.WriteLine(pr.CalculateDiscount());
            pr = new ClothingProduct { Price = 2000 };
            Console.WriteLine(pr.CalculateDiscount());
            pr = new GroceryProduct { Price = 500 };
            Console.WriteLine(pr.CalculateDiscount());

            // ✅ Problem 10
            GameCharacter gc;
            gc = new Warrior(); gc.Attack();
            gc = new Mage(); gc.Attack();
            gc = new Archer(); gc.Attack();
        }
    }
}