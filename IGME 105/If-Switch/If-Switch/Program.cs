using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("You have been traveling through the desert for months with your companion and you are low on supplies.");
            Console.WriteLine("Both you and your traveling companion are starving.");
            Console.WriteLine("Your companion's pace begins to decrease and you notice him/her collapse on the ground a few feet behind you.");
            Console.WriteLine("It has been a week since you last had a meal. What do you do?");
            Console.WriteLine("1: Eat companion.");
            Console.WriteLine("2: Help companion.");
            int firstChoice = int.Parse(Console.ReadLine());

           if(firstChoice == 1)
            {
                Console.WriteLine("You turn around and look at your companion on the ground. He/She looks helpless. You utter a pathetic apology as you knock them out with a rock...");
            }
           else if(firstChoice == 2)
            {
                Console.WriteLine("You turn around and look at your companion on the ground. He/She looks helpless. You act as support and lift your companion up to their feet.");
            }
            else
            {
                Console.WriteLine("That was not an option.");
            }

            Console.WriteLine();
            Console.WriteLine("You see a group of survivors up ahead, but they look unfriendly. How do you approach them?");
            Console.WriteLine("1: Guns blazin'");
            Console.WriteLine("2: Calmly. They might have shelter and supplies.");
            int secondChoice = int.Parse(Console.ReadLine());
        
            switch(secondChoice)
            {
                case 1: Console.WriteLine("You run at the group of survivors with your revolver out, shooting crazily at anything that moves.");
                        Console.WriteLine("You end up killing your wife and two children that you had gotten separated from a month earlier."); break;
                case 2: Console.WriteLine("You calmly approach the group of survivors. They let you in their camp and offer you food and shelter."); break;
                default:Console.WriteLine("That was not an option"); break;
            }

            if(firstChoice == 1 && secondChoice == 1)
            {
                Console.WriteLine("You ate your companion and killed your wife and kids. Why?");
            }
            else if (firstChoice == 1 && secondChoice == 2)
            {
                Console.WriteLine("You ate your companion but ended up joining a nice group of survivors that help you with the PTSD that you now have.");
            }
            else if(firstChoice == 2 && secondChoice == 1)
            {
                Console.WriteLine("Your companion ditches you after your massacre of the group of survivors. You should have ate him/her.");
            }
            else if (firstChoice == 1 && secondChoice == 2)
            {
                Console.WriteLine("You and your companion live peacefully with the group of survivors.");
            }
            else
            {
                Console.WriteLine("What are you doing?");
            }
        }
    }
}
