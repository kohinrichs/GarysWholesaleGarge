using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The silver Cessna races overhead. Zzzzzzoooooom!");
        }
    }
}