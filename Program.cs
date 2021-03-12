using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram150 = new Ram();

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();

            modelS.Drive();
            modelS.Turn();
            modelS.Stop();

            mx410.Drive();
            mx410.Turn();
            mx410.Stop();

            ram150.Drive();
            ram150.Turn();
            ram150.Stop();
        }
    }
}
