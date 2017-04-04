using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a random number generator
            Random rng = new Random();
            int answer= rng.Next(0, 101);

            Console.WriteLine("Let's play a game!");
            Console.WriteLine("I will choose a number 0-100. You will have 8 attempts at guessing my number.");

            int guess = 1;
            while (guess < 9)
            {
                Console.Write("Enter your guess: ");
                int guessedNumber = int.Parse(Console.ReadLine());

                if(guessedNumber == answer)
                {
                    Console.WriteLine("Correct! You won in " + guess + " turns.");
                    break;
                }

                //In the case of an invalid number
                if(guessedNumber > 100 || guessedNumber < 0)
                {
                    Console.WriteLine("Invalid guess. Try again.");
                    continue;
                }
                if(guessedNumber > answer)
                {
                    Console.WriteLine("Too high.");
                    guess++;
                    Console.WriteLine("Turn #" + guess);
                    continue;
                }
                if(guessedNumber < answer)
                {
                    Console.WriteLine("Too low.");
                    guess++;
                    Console.WriteLine("Turn #" + guess);
                    continue;
                }
            }
            if(guess > 8)
            {
                Console.WriteLine("You ran out of turns. The number was " + rng.Next(0, 101));
            }
        }
    }
}
