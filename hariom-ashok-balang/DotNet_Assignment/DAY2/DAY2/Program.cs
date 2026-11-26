using System;
namespace DAY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BankAccount acc = new BankAccount();
            acc.Deposit(1000);
            acc.Withdraw(200);
            Console.WriteLine($"Balance: {acc.Balance}");

            Employee emp = new Employee { EmpId = 1, Name = "Alice", Salary = 50000 };
            Console.WriteLine($"Employee Salary: {emp.Salary}");

            Product prod = new Product { ProductId = 1, Name = "Laptop", Price = 80000 };
            Console.WriteLine($"Product Price: {prod.Price}");

            MobilePhone phone = new MobilePhone();
            phone.BatteryPercentage = 85;
            Console.WriteLine($"Battery: {phone.BatteryPercentage}%");

            Book book = new Book();
            book.IssueBook();
            Console.WriteLine($"Available: {book.IsAvailable()}");
            book.ReturnBook();

            Car car = new Car();
            car.Speed = 120;
            Console.WriteLine($"Car Speed: {car.Speed}");

            CartItem item = new CartItem { ItemName = "Mouse", Price = 500, Quantity = 3 };
            Console.WriteLine($"Cart Quantity: {item.Quantity}");

            User user = new User();
            user.Username = "hariom";
            user.SetPassword("1234");
            Console.WriteLine($"Password Valid: {user.ValidatePassword("1234")}");

            Rectangle rect = new Rectangle { Length = 5, Width = 4 };
            Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");
        }
    }
}