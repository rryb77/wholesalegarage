using System;

namespace wholesalegarage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} RAM zips by you. BrRrRRRrRRRrrRrMMMMMMMM!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turned {direction} while jamming country music!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram barely stopped.");
        }
    }
}