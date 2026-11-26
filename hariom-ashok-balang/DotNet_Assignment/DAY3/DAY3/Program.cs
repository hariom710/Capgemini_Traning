using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;

namespace DAY3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // ✅ Problem 1: Animal
            Animal a;

            a = new Dog();
            a.MakeSound();

            a = new Cat();
            a.MakeSound();


            // ✅ Problem 2: Employee
            Employee emp;

            emp = new FullTimeEmployee { Name = "Alice", BasicSalary = 50000 };
            Console.WriteLine($"Full Time Salary: {emp.CalculateSalary()}");

            emp = new PartTimeEmployee { Name = "Bob", BasicSalary = 20000 };
            Console.WriteLine($"Part Time Salary: {emp.CalculateSalary()}");


            // ✅ Problem 3: Shape
            Shape sh;

            sh = new Circle { Radius = 5 };
            Console.WriteLine($"Circle Area: {sh.CalculateArea():F2}");

            sh = new Rectangle { Length = 4, Width = 6 };
            Console.WriteLine($"Rectangle Area: {sh.CalculateArea():F2}");

            sh = new Triangle { Base = 3, Height = 8 };
            Console.WriteLine($"Triangle Area: {sh.CalculateArea():F2}");


            // ✅ Problem 4: Vehicle
            Vehicle v;

            v = new Car();
            v.StartEngine();

            v = new Bike();
            v.StartEngine();

            v = new Truck();
            v.StartEngine();


            // ✅ Problem 5: Bank Account
            BankAccount acc;

            acc = new SavingsAccount { Balance = 10000 };
            Console.WriteLine($"Savings Interest: {acc.CalculateInterest()}");

            acc = new CurrentAccount { Balance = 10000 };
            Console.WriteLine($"Current Interest: {acc.CalculateInterest()}");

            acc = new FixedDepositAccount { Balance = 10000 };
            Console.WriteLine($"FD Interest: {acc.CalculateInterest()}");


            // ✅ Problem 6: Student
            Student st;

            st = new SchoolStudent { Marks = 88 };
            Console.WriteLine($"School Grade: {st.GetGrade()}");

            st = new CollegeStudent { Marks = 78 };
            Console.WriteLine($"College Grade: {st.GetGrade()}");


            // ✅ Problem 7: Media Player
            MediaFile mf;

            mf = new AudioFile();
            mf.Play();

            mf = new VideoFile();
            mf.Play();

            mf = new ImageFile();
            mf.Play();


            // ✅ Problem 8: Payment
            Payment pay;

            pay = new CreditCardPayment();
            pay.ProcessPayment(1200);

            pay = new UPIPayment();
            pay.ProcessPayment(500);

            pay = new PayPalPayment();
            pay.ProcessPayment(900);


            // ✅ Problem 9: Notification (Interface)
            INotification note;

            note = new EmailNotification();
            note.Send("Welcome via Email");

            note = new SMSNotification();
            note.Send("Welcome via SMS");

            note = new PushNotification();
            note.Send("Welcome via Push");


            // ✅ Problem 10: Game Character
            GameCharacter gc;

            gc = new Warrior();
            gc.Attack();

            gc = new Mage();
            gc.Attack();

            gc = new Archer();
            gc.Attack();
        }
    }
}