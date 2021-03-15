using System;

namespace wholesalegarage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna flies by you. COOOOKOOOKOKOKOKKKKKKK!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna took a wide turn {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna finally rolls to a stop after terrifying passengers.");
        }
    }
}