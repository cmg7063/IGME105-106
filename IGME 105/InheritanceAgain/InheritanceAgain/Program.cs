using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            Barracks barracks = new Barracks();

            int count = 1;
            while(count < 10)
            {
                DefaultCharacter character = new DefaultCharacter("UNKNOWN", 0, 0, 0);
                character = barracks.SpawnCharacter("UNKNOWN", 0, 0, 0);
                count++;
                Console.WriteLine(character.ToString());

                if (character is Wizard)
                {
                    Wizard wizard = (Wizard)character;
                    wizard.HotPocketPercent = 60;
                    Console.WriteLine(wizard.ToString());
                }
                if (character is Warrior)
                {
                    Warrior warrior = (Warrior)character;
                    warrior.SmellFactor = 8;
                    Console.WriteLine(warrior.ToString());
                }
                if (character is Thief)
                {
                    Thief thief = (Thief)character;
                    thief.CellRings = 19;
                    Console.WriteLine(thief.ToString());
                }
            }

        }
    }
}
