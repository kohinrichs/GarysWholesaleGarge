using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx, fxs, modelS
            };

            fx.CurrentChargePercentage = 54;
            fxs.CurrentChargePercentage = 76;
            modelS.CurrentChargePercentage = 87;

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}%");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}%");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
                          };

            ram.CurrentTankPercentage = 45;
            cessna150.CurrentTankPercentage = 89;

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }
        }
    }
}


// namespace GarysWholesaleGarage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero();
//             Tesla modelS = new Tesla();
//             Cessna mx410 = new Cessna();
//             Ram ram150 = new Ram();

//             fxs.Drive();
//             fxs.Turn();
//             fxs.Stop();

//             modelS.Drive();
//             modelS.Turn();
//             modelS.Stop();

//             mx410.Drive();
//             mx410.Turn();
//             mx410.Stop();

//             ram150.Drive();
//             ram150.Turn();
//             ram150.Stop();
//         }
//     }
// }