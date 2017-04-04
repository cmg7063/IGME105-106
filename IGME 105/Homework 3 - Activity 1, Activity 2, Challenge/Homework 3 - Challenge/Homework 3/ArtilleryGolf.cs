using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class ArtilleryGolf
    {
        private double cannonLength;

        public ArtilleryGolf(double cannonLength)
        {
            this.cannonLength = cannonLength;
        }

        public double Fire(double angle, double velocity)
        {
            if (angle < 0)
            {
                angle = 0.0;
            }
            if (angle > 90)
            {
                angle = 90.0;
            }

            double angleConversion = Math.PI / 180;
            double time = Math.Sqrt((velocity * Math.Sin(angleConversion)) + ((velocity * velocity) * (Math.Sin(angleConversion) * Math.Sin(angleConversion)) + 20.0 * cannonLength * Math.Sin(angleConversion))) / 10.0;
            double cannonDistance = velocity * Math.Cos(angleConversion) * time;
            return cannonDistance;
        }
    }
}
