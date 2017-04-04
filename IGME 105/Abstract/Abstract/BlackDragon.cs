using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class BlackDragon : Dragon
    {
        public BlackDragon(int health, String name, Random rng): base (health, name, rng)
        {
        }

        public override int Attack()
        {
            Console.WriteLine("The Black Dragon attacked with fire breath.");
            return rng.Next(10, 21);
        }

        public override string ToString()
        {
            return "The Black Dragon " + base.ToString() + " and attacks with fire."; 
        }
    }
}
