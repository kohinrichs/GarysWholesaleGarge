using System;

namespace GarysWholesaleGarage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
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
            Console.WriteLine("The silver Ram rumbles past you. RRrrrrrumble");
        }
    }
}
