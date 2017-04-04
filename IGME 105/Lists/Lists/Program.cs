using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.AddToInventory("Moldy Sandwich");
            player.AddToInventory("Expired Milk");
            player.AddToInventory("Broken Cellphone");
            player.AddToInventory("Pen Cap");

            Console.WriteLine("Welcome!");
            while (1 == 1)
            {
                Console.Write("Enter a command (print, get, done): ");
                String userInput = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (userInput == "done")
                {
                    break;
                }
                else if(userInput == "print")
                {
                    Console.WriteLine("The Player's Inventory: ");
                    player.PrintInventory();
                    Console.WriteLine();
                    continue;
                }
                else if(userInput == "get")
                {
                    Console.Write("Which item would you like to get? ");
                    int userItem = Int32.Parse(Console.ReadLine());
                    if (player.CalculateSize(userItem) == false)
                    {
                        Console.WriteLine("That is not a valid index.");
                        Console.WriteLine();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Removed item at slot " + userItem + ": " + player.GetItemInSlot(userItem));
                        Console.WriteLine();
                        continue;
                    }
                }
                else
                {
                    player.AddToInventory(userInput);
                    Console.WriteLine("Item '" + userInput + "' added to the Player's inventory.");
                    Console.WriteLine();
                }
            }
        }
    }
}
