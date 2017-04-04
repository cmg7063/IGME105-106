using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            BlackDragon bdragon = new BlackDragon(100, "Neal", rand);
            FrostDragon fdragon = new FrostDragon(110, "Astrid", rand);
            Console.WriteLine(bdragon.ToString());
            Console.WriteLine(fdragon.ToString());

            while (bdragon.Health > 0 && fdragon.Health > 0)
            {
                fdragon.Health -= bdragon.Attack();

                bdragon.Health -= fdragon.Attack();
            }
            
            if(bdragon.Health <= 0)
            {
                Console.WriteLine("The Frost Dragon won!");
            }
            else
            {
                Console.WriteLine("The Black Dragon won!");
            }
        }
    }
}
