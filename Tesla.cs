using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
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
            Console.WriteLine("The white Tesla zips past you. Zipzipzipzip");
        }
    }
}