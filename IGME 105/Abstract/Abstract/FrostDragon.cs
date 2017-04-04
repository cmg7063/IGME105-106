using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class FrostDragon : Dragon
    {
        public FrostDragon(int health, String name, Random rng) : base (health, name, rng)
        {

        }

        public override int Attack()
        {
            Console.WriteLine("The Frost Dragon attacked with frost breath.");
            return rng.Next(5, 26);
        }

        public override string ToString()
        {
            return "The Frost Dragon " + base.ToString() + " and freezes enemies.";
        }
    }
}
