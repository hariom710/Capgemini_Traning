using System;

namespace DAY1_ASSIGNMENT
{
    internal class MobilePhone
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int BatteryPercentage { get; set; }

        public void ChargePhone()
        {
            if (BatteryPercentage < 100)
            {
                BatteryPercentage += 10;

                if (BatteryPercentage > 100)
                    BatteryPercentage = 100;

                Console.WriteLine("Phone charged.");
            }
            else
            {
                Console.WriteLine("Battery already full.");
            }
        }

        public void UsePhone()
        {
            if (BatteryPercentage > 0)
            {
                BatteryPercentage -= 10;
                Console.WriteLine("Phone used.");
            }
            else
            {
                Console.WriteLine("Battery empty. Please charge.");
            }
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Brand   : {Brand}");
            Console.WriteLine($"Model   : {Model}");
            Console.WriteLine($"Battery : {BatteryPercentage}%");
        }
    }
}
