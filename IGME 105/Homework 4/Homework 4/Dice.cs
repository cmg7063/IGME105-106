using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Dice
    {
        // Generate new random object
        Random rng = new Random();

        public Dice()
        {
            this.rng = rng;
        }

        public int Roll1Die()
        {
            // Simulates the roll of one six-sided dice
            int numberRolled = rng.Next(1, 7);
            return numberRolled;
        }

        public int Roll2Dice()
        {
            // Simulates the roll of one six-sided dice
            int numberRolled = rng.Next(1, 7);
            return numberRolled;

            // Simulates the roll of the second six-sided dice
            int numberRolled2 = rng.Next(1, 7);
            return numberRolled2;

        }
    }
}
