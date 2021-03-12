using System;

namespace wholesalegarage
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
            Console.WriteLine($"The {MainColor} Tesla cruises by. *silence*");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla smugly turned {direction}!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla quietly stopped.");
        }
    }
}