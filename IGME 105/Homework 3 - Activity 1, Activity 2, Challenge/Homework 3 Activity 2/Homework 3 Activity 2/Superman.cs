using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3_Activity_2
{
    class SuperMan
    {
        private int targetHeight;

        public SuperMan(int targetHeight)
        {
            this.targetHeight = targetHeight;
        }

        public double Leap(double gravitationalConstant)
        {
            double velocity = Math.Sqrt(2 * gravitationalConstant * targetHeight);
            return velocity;
        }
    }
}
