using System;

namespace wholesalegarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. ZoooooOoooOOOOom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero quickly turned {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero owner is now standing at a red light.");
        }
    }
}