using System;

namespace GarysWholesaleGarage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The lime green Zero races around the curve. Eeeeeeeeep!");
        }


        public override void Turn()
        {
            Console.WriteLine("The Zero makes a sharp left turn.");
        }
    }
}