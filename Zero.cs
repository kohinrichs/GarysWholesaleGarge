using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging battery");
            CurrentChargePercentage = 100;
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