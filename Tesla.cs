using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The white Tesla zips past you. Zipzipzipzip");
        }
    }
}