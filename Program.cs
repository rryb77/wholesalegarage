using System;

namespace wholesalegarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero()
            {
                MainColor = "Midnight Blue"
            };
            Tesla modelS = new Tesla()
            {
                MainColor = "Fire Red"
            };
            Cessna mx410 = new Cessna()
            {
                MainColor = "Mustard Yellow"
            };
            Ram f150 = new Ram()
            {
                MainColor = "Dirt Brown"
            };

            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            Console.WriteLine("");
            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            Console.WriteLine("");
            mx410.Drive();
            mx410.Turn("north");
            mx410.Stop();
            Console.WriteLine("");
            f150.Drive();
            f150.Turn("south");
            f150.Stop();
            Console.WriteLine("");
        }
    }
}
