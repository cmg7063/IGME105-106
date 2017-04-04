using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Monopoly
    {
        Dice dice = new Dice();
    
        private String[] propertyNames = {"Go", "Mediterranean Avenue", "Community Chest (1)", "Baltic Avenue", "Income Tax", "Reading Railroad", "Oriental Avenue", "Chance (1)", "Vermont Avenue", "Connecticut Avenue", "Jail", "St. Charles Place", "Electric Company", "States Avenue", "Virginia Avenue", "Pennsylvania Railroad", "St. James Place", "Community Chest (2)", "Tennessee Avenue", "New York Avenue", "Free Parking", "Kentucky Avenue", "Chance (2)", "Indiana Avenue", "Illinois Avenue", "B&O Railroad", "Atlantic Avenue", "Ventnor Avenue", "Water Works", "Marvin Gardens", "Go To Jail", "Pacific Avenue", "North Carolina Avenue", "Community Chest (3)", "Pennsylvania Avenue", "Short Line Railroad", "Chance (3)", "Park Place", "Luxury Tax", "Boardwalk"};
        int players = 10000;
        int playerTurns = 25;

        public Monopoly()
        {
            this.dice = dice;
        }

        public double[] Analyze()
        {
            int[] visits = new int[propertyNames.Length];

            for (int players = 1; players <= 10000; players++)
            {
                int playerPosition = 0;
                int boardRotations = 1;
                while (boardRotations < 25)
                {
                    visits[playerPosition]++;
                    if (propertyNames[playerPosition] == "Go To Jail")  // If the value in the propertyNames array is "Go To Jail"
                    {
                        boardRotations++;   // Increment boardRotations
                    }
                    else
                    {
                        playerPosition = playerPosition + dice.Roll2Dice();

                        if (playerPosition > visits.Length)
                        {
                            boardRotations = 1;
                        }
                        else
                        {
                            boardRotations = 0;
                        }

                        playerPosition = playerPosition % visits.Length;
                    }
                }
            }
            double sum = (double)visits.Sum();
            // Select() allows me to change all the values in the array which is great because apparently you can't multiply/divide arrays by constants
            double[] percent = visits.Select(v => (double)(v / sum) * 100).ToArray();
            return percent;
        }

        public void PrintResults(double[] percent)
        {
            for (int i = 0; i < propertyNames.Length; i++)
            {
                Console.WriteLine(propertyNames[i] + ": " + "{0:F2}", percent[i]);
            }
        }
    }
}
