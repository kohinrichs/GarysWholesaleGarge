using System;

namespace GarysWholesaleGarage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The silver Ram rumbles past you. RRrrrrrumble");
        }
    }
}
