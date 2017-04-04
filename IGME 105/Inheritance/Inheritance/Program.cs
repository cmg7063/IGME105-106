using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            PurplePinwheel pinwheel = new PurplePinwheel();
            pinwheel.Spawn();
            pinwheel.Bouncing();
            Console.WriteLine();

            GreenSquare square = new GreenSquare();
            square.Spawn();
            square.BackOff("shoot");
            Console.WriteLine();

            BlueDiamond diamond = new BlueDiamond();
            diamond.Spawn();
            diamond.Chase();
            Console.WriteLine();

            PinkX x = new PinkX();
            x.Spawn();
            x.SplitUp();
        }
    }
}
