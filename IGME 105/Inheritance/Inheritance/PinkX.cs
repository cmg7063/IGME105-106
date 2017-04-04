using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class PinkX : Enemy
    {
        private int divide;
        public PinkX()
        {
            this.shape = "Pink X";
            this.color = "Pink";
            this.divide = 10;
        }

        public void SplitUp()
        {
            Console.WriteLine("The Pink X has been hit and split into " + divide + " enemies.");
        }
    }
}
