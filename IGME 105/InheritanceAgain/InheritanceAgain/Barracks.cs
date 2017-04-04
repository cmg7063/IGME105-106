using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAgain
{
    class Barracks
    {
        Random random = new Random();

        public DefaultCharacter SpawnCharacter(String name, int strength, int dexterity, int intelligence)
        {
            int chance = random.Next(0, 101);

            if (chance > 0 && chance <= 60)
            {
                DefaultCharacter warrior = new Warrior("Warrior", 15, 5, 5, 20);
                return warrior;
            }
            else if (chance > 60 && chance <= 90)
            {
                DefaultCharacter wizard = new Wizard("Wizard", 5, 10, 10, 60);
                return wizard;
            }
            else if (chance > 90 && chance <= 100)
            {
                DefaultCharacter thief = new Thief("Thief", 10, 5, 5, 10);
                return thief;
            }
            DefaultCharacter dchar = new DefaultCharacter("UNKNOWN", 0, 0, 0);
            return dchar;
        }
    }
}
