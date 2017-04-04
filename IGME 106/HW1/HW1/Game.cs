using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Corinne Green
// Game - A class that implements methods from ZombieData and ultimately runs the game
namespace HW1
{
    class Game
    {
        // Attributes
        int playerLife;
        int score;
        int zombieTimer;
        int letterIndex;
        ZombieData zombie;

        // Constructor that initializes each of the attributes
        public Game()
        {
            zombie = new ZombieData();
            playerLife = 5;
            score = 0;
            letterIndex = 0;
            zombie.LoadPhrases("phrases.txt");
            zombie.LoadZombies();
        }

        public void PlayGame()
        {
            // This bool only returns true when the zombie has been killed
            bool zombieKilled = false;
            string phraseLetter = "";

            while (playerLife > 0)
            {
                if (zombieKilled == false)
                {
                    zombieTimer = 0;
                    letterIndex = 0;
                    zombieKilled = true;
                    phraseLetter = zombie.RandomPhrase();
                    Console.WriteLine("Score: " + score);   // Print the player's score to the screen

                    // Store the randomly generated phrase as a string so we can use it later
                    Console.WriteLine(zombie.RandomZombie());
                    Console.WriteLine(phraseLetter);
                }
                while (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    string letter = key.KeyChar.ToString().ToUpper();
                    string firstLetter = phraseLetter[letterIndex].ToString().ToUpper();

                    // If the user inputted letter matches the first letter of the random phrase,
                    // Print "!"
                    if (letter == firstLetter)
                    {
                        letterIndex++;
                            Console.Write("!");
                        }
                        else
                        {
                            letterIndex = 0;
                            Console.Write(":(");
                        }

                        // Bool zombieKilled is true in the instance that the letterIndex is greater 
                        // Than the phraseLength, meaning that the zombie has been killed. We must
                        // Then reset all necessary variables.  
                        if (letterIndex >= phraseLetter.Length)
                        {
                            zombieKilled = false;
                            letterIndex = 0;
                            zombieTimer = 0;
                            score += 100;
                        }
                        // Otherwise, if the letterIndex is less than length of the random phrase,
                        // Remove a life from playerLife, reset zombieTimer, and set bool something 
                        // To false.
                        else if (letterIndex < phraseLetter.Length && zombieTimer == 4000 - score)
                        {
                            zombieKilled = false;
                            playerLife -= 1;
                            zombieTimer = 0;
                            Console.WriteLine("Player Health: " + playerLife);
                        }
                    }
                    // Send the system to sleep for 50 milliseconds, an add that to zombieTimer
                    System.Threading.Thread.Sleep(50);
                    zombieTimer += 50;
                }
            }
    }
}
