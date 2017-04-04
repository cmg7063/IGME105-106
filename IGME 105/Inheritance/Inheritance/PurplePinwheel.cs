using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PurplePinwheel : Enemy
    {
        private String bounce;
        public PurplePinwheel()
        {
            this.color = "Purple";
            this.shape = "Pinwheel";
            this.bounce = "everywhere";
        }

        public void Bouncing()
        {
            Console.WriteLine("The Purple Pinwheel is bouncing " + bounce + ".");
        }
    }
}
