using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Corinne Green
// The purpose of this class is to learn
// how to handle exceptions with try/catch

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            String [] str = {"headphones", "phone", "gum", "chapstick", "pencil", "eraser", "notebook" };

            // Print out the array of words
            Console.WriteLine("Welcome! The current data is: ");
            foreach (String word in str)
            {
                Console.WriteLine(word);
            }

            // A loop that does not break unless user enters "quit"
            while (1==1)
            {
                Console.WriteLine();
                Console.WriteLine("Enter a command or line number to change:");
                String userInput = Console.ReadLine();
                Console.WriteLine();
                try
                {
                    // Parse the userInput into an int
                    int num = int.Parse(userInput);

                    Console.WriteLine("Enter the new value: ");     // Because NUM is parsed and checked for exceptions here, to
                    String userInsert = Console.ReadLine();         // reference the variable again I must do so between these brackets
                    str[num] = userInsert;
                }
                catch(FormatException e)
                {
                    if (userInput == "print")
                    {
                        foreach(String word in str)
                        {
                            Console.WriteLine(word);
                        }
                    }
                    if (userInput == "quit")
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    if (userInput != "print" || userInput != "quit")
                    {
                        Console.WriteLine("Invalid command!");
                    }
                    continue;
                }
                catch(IndexOutOfRangeException ior)
                {
                    Console.WriteLine("The line number you entered is invalid!");
                }
            }
        }
    }
}
