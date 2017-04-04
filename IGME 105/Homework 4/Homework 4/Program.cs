using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new dice object
            Dice dice = new Dice();

            Console.WriteLine("Start of Roll2Dice()");

            // A loop that will call Roll1Dice() 100 times
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(dice.Roll1Die());
            }

            Console.WriteLine();
            Console.WriteLine("Start of Roll2Dice()");

            // A loop that will call Roll2Dice() 100 times
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(dice.Roll2Dice());
            }

            Console.WriteLine("End of Roll2Dice()");
            Console.WriteLine();

            Console.WriteLine("Study Results:");
            Monopoly mono = new Monopoly();
            double[] results = mono.Analyze();
            mono.PrintResults(results);
        }
    }
}
