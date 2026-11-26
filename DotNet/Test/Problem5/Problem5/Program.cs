using System;

namespace Problem5
{
    internal class Program
    {
        interface IVehiculo
        {
            void Drive();
            bool Refuel(int amount);
        }
        class Car : IVehiculo
        {
            private int _gasoline;
            public Car(int startingGasoline)
            {
                _gasoline = startingGasoline;
            }
            public void Drive()
            {
                if (_gasoline > 0)
                {
                    Console.WriteLine("Driving");
                }
                else
                {
                    Console.WriteLine("Cannot drive: no gasoline");
                }
            }
            public bool Refuel(int amount)
            {
                if (amount < 0) return false;
                _gasoline += amount;
                return true;
            }
        }
        static void Main(string[] args)
        {
            var car = new Car(0);
            Console.Write("Enter amount of gasoline to refuel: ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int amount))
            {
                if (amount < 0)
                {
                    Console.WriteLine("Amount must be non-negative.");
                }
                else
                {
                    bool ok = car.Refuel(amount);
                    Console.WriteLine(ok ? $"Refueled {amount} units." : "Refuel failed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid number entered.");
            }
            car.Drive();
        }
    }
    
}
