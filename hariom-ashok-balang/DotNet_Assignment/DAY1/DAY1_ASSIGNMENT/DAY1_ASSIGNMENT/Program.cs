namespace DAY1_ASSIGNMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Student student1 = new Student { Id = 1, Name = "Alice", Marks = 85 };
            Student student2 = new Student { Id = 2, Name = "Bob", Marks = 90 };
            Console.WriteLine(student1.Display());
            Console.WriteLine(student2.Display());  

            BankAccount account1 = new BankAccount { AccountNumber = 123456, AccountHolderName = "Alice", Balance = 1000 };
            account1.Deposit(500);       
            account1.Withdraw(200);       
            Console.WriteLine(account1.Balance);


            Car car1 = new Car { Brand = "Toyota", Model = "Camry", Speed = 420 };
            car1.Accelerate();
            car1.Brake();
            car1.DisplayCarInfo();


            Employee employee1 = new Employee { EmpId = 1, Name = "Alice", BasicSalary = 50000 };
            Console.WriteLine($"Total Salary for {employee1.Name}: {employee1.CalculateTotalSalary()}");

            Book book1 = new Book { BookId = 1, Title = "C# Programming", Author = "John Doe", IsAvailable = true };
            book1.IssueBook();
            book1.ReturnBook();

            Product product1 = new Product { ProductId = 1, Name = "Laptop", Price = 1000 };
            product1.AddStock(10);
            product1.SellProduct(2);
            product1.ShowProductDetails();


            Rectangle rectangle1 = new Rectangle { Length = 5, Width = 3 };
            rectangle1.Width = 4;
            Console.WriteLine($"Area of Rectangle: {rectangle1.CalculateArea()}");


            MobilePhone phone1 = new MobilePhone { Brand = "Apple", Model = "iPhone 14", BatteryPercentage = 87 };
            phone1.ChargePhone();
            phone1.UsePhone();
            phone1.ShowStatus();


            CartItem item1 = new CartItem
            {
                ItemName = "Keyboard",
                Price = 1500,
                Quantity = 2
            };

            Console.WriteLine($"Total Price: {item1.CalculateTotalPrice()}");


            Calculator calc = new Calculator();

            Console.WriteLine($"Add: {calc.Add(10, 5)}");
            Console.WriteLine($"Subtract: {calc.Subtract(10, 5)}");
            Console.WriteLine($"Multiply: {calc.Multiply(10, 5)}");
            Console.WriteLine($"Divide: {calc.Divide(10, 5)}");





        }
    }
}
