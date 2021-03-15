using System;


namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle, IGasVehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine("Filling tank!");
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine("The silver Cessna races overhead. Zzzzzzoooooom!");
        }
    }
}