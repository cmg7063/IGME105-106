using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArtilleryGolf golf = new ArtilleryGolf(2.0);

            while (1 == 1)
            {
                Console.Write("Enter the initial velocity of the cannonball: ");
                double userVelocity = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle of the cannon (between 0 and 90 degrees): ");
                double userAngle = double.Parse(Console.ReadLine());

                double targetDistance = 751 - golf.Fire(userAngle, userVelocity);

                Console.WriteLine("Your shot hit " + golf.Fire(userAngle, userVelocity) + " meters. The target is " + targetDistance + " meters \n away.");
                Console.WriteLine();
                
                if (targetDistance <= 0.5 && targetDistance >= -0.5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You hit the target!");
                    break;
                }

            }
        }
    }
}
