using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create character
            Console.WriteLine("Enter your character's name:");
            string characterName = Console.ReadLine();
            Console.WriteLine();

            //These are the attributes
            int maxPoints = 50;
            int luck = maxPoints % 40;
            int intelligence = luck / 2;
            int charisma = 7;
            int perception = (intelligence + charisma) -2;
            int agility = (maxPoints) - (luck + intelligence + charisma + perception);

            //Calculate total points; should be equal to maxPoints
            int total = luck + intelligence + charisma + perception + agility;

            //Print total
            Console.WriteLine("Name:" + characterName);
            Console.WriteLine("Luck:" + luck);
            Console.WriteLine("Intelligence:" + intelligence);
            Console.WriteLine("Charisma:" + charisma);
            Console.WriteLine("Perception:" + perception);
            Console.WriteLine("Agility:" + agility);
            Console.WriteLine("Total:" + total);


        }
    }
}
