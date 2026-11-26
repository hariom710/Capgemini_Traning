using System;
namespace DAY2
{
    internal class Car
    {
        private int _speed;
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value >= 0)
                    _speed = value;
                else
                    Console.WriteLine("Speed cannot be negative.");
            }
        }
    }
}