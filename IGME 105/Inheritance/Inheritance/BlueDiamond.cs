using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class BlueDiamond : Enemy
    {
      //  private int chase;
        public BlueDiamond()
        {
            this.color = "Blue";
            this.shape = "Diamond";
            this.speed = 100;
        }

        public void Chase()
        {
            Console.WriteLine("The Blue Diamond is chasing you!");
        }
    }
}
