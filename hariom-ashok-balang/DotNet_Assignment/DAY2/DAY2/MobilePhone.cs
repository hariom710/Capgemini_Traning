using System;
namespace DAY2
{
    internal class MobilePhone
    {
        private int _batteryPercentage;
        public int BatteryPercentage
        {
            get { return _batteryPercentage; }
            set
            {
                if (value >= 0 && value <= 100)
                    _batteryPercentage = value;
                else
                    Console.WriteLine("Battery must be between 0 and 100.");
            }
        }
    }
}