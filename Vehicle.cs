using System;

namespace GarysWholesaleGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooooom!");
        }

        public virtual void Turn()
        {
            Console.WriteLine("The vehicle makes a gentle right turn.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop.");
        }
    }
}