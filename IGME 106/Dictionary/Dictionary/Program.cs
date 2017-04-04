using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Corinne Green
// The purpose of this class is to create a pre-populated Dictionary
// The words in this Dictionary are "cromulent, somnambulist, sonorous, petrichor, supine, syzygy"
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize new Dictionary object
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // Add items to Dictionary
            dictionary.Add(1, "CROMULENT");
            dictionary.Add(2, "SOMNAMBULIST");
            dictionary.Add(3, "SONOROUS");
            dictionary.Add(4, "PETRICHOR");
            dictionary.Add(5, "SUPINE");
            dictionary.Add(6, "SYZYGY");

            // A loop that does not break unless user enters "EXIT"
            while (1==1)
            {
                Console.WriteLine("Enter a word you would like to define: ");
                String userInput = Console.ReadLine().Trim().ToUpper();

                if (dictionary.ContainsValue(userInput))
                {
                    if(userInput == "CROMULENT")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (n) appearing legitimate but actually being spurious");
                    }
                    if (userInput == "SOMNAMBULIST")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (n) a person who sleepwalks");
                    }
                    if (userInput == "SONOROUS")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (adj) an imposingly deep and full sound");
                    }
                    if (userInput == "PETRICHOR")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (n) the pleasant, earthy smell after rain");
                    }
                    if (userInput == "SUPINE")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (adj) lying face upwards");
                    }
                    if (userInput == "SYZYGY")
                    {
                        Console.WriteLine(userInput.ToLower() + ": (n) an alignment of celestial bodies");
                    }
                }
                if (userInput == "EXIT")
                {
                    break;
                }
                else if (!dictionary.ContainsValue(userInput))
                {
                    Console.WriteLine("The dictionary does not contain the word " + userInput.ToLower());
                }
            }

        }
    }
}
