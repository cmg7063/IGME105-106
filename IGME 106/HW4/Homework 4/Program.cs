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
            LinkedList list = new LinkedList();
            Random rng = new Random(); // This will handle the removal of random elements and scrambling

            Console.WriteLine("Welcome to the Linked List Homework...");

            while (1 == 1)
            {
                Console.Write("Type something: ");
                string userInput = Console.ReadLine().ToLower();

                if (userInput.Equals("q") || userInput.Equals("quit"))
                {
                    break;
                }
                else if (userInput.Equals("print"))
                {
                    Console.WriteLine("The following items are in the list: ");
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list.GetElement(i));
                    }
                }
                else if (userInput.Equals("count"))
                {
                    Console.WriteLine("There are currently " + list.Count + " items in the list");
                }
                else if (userInput.Equals("clear"))
                {
                    list.Clear();
                    Console.WriteLine("The list has been cleared");
                }
                else if (userInput.Equals("remove"))
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Error: You must first add something to the list before attempting to remove");
                        continue;
                    }
                    // Remove random element from list
                    string element = list.Remove(rng.Next(0, list.Count));
                    Console.WriteLine(element + " has been removed from the list");
                }
                else if (userInput.Equals("scramble"))
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("Error: You must first add something to the list before attempting to scramble");
                        continue;
                    }
                    else
                    {
                        string randomElement = list.Remove(rng.Next(0, list.Count));
                        list.Insert(randomElement, rng.Next(0, list.Count));
                        Console.WriteLine("Scramble successful");
                    }
                }
                // If user does not enter any of the defined commands, add input to list
                else
                {
                    list.Add(userInput);
                    Console.WriteLine("\"" + userInput + "\" has been added to the list");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Thanks for typing!");
        }
    }
}