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

            Random rng = new Random();
            int distance = rng.Next(0, 500);

            Console.WriteLine("Let's play Artillery Golf! You will have 5 chances to hit the randomly \n generated target distance.");
            Console.WriteLine();

            int guess = 1;
            while (guess <= 6)
            {
                Console.Write("Enter the initial velocity of the cannonball: ");
                double userVelocity = double.Parse(Console.ReadLine());
                Console.Write("Enter the angle of the cannon (between 0 and 90 degrees): ");
                double userAngle = double.Parse(Console.ReadLine());

                double targetDistance = distance - golf.Fire(userAngle, userVelocity);

                if (guess < 6 && (targetDistance >= 0.5 || targetDistance <= -0.5))
                {
                    Console.WriteLine("Miss! Your shot hit " + golf.Fire(userAngle, userVelocity) + " meters. The target is " + targetDistance + " \n meters away.");
                    Console.WriteLine();
                    guess++;
                    continue;
                }
                
                if (targetDistance <= 0.5 && targetDistance >= -0.5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hit! Congratulations! You hit the target!");
                    //continue;
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to play again? (Y/N)");
                Console.WriteLine();
                String secondAnswer = Console.ReadLine();
                secondAnswer = secondAnswer.Trim();
                String againResponse = secondAnswer.ToLower();

                if (againResponse == "y")
                {
                    continue;
                }
                else if (againResponse == "n")
                {
                    break;
                }
            }
        }
    }
}
