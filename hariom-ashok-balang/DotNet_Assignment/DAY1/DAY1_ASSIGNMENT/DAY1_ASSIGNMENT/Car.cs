using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DAY1_ASSIGNMENT
{
    internal class Car
    {
        //Ceate a Car class with : - Properties: Brand, Model, Speed - Methods: - Accelerate() - Brake() - DisplayCarInfo()
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Accelerate()
        {
            Speed += 10;
            Console.WriteLine($"Accelerated. Current Speed: {Speed} km/h");
        }

        public void Brake()
        {
            if (Speed >= 10)
            {
                Speed -= 10;
                Console.WriteLine($"Braked. Current Speed: {Speed} km/h");
            }
            else
            {
                Console.WriteLine("Car is already stopped.");
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Speed: {Speed} km/h");
        }

    }
}
