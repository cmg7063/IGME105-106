using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            RPGCharacter newChar = new RPGCharacter();
            newChar.setupCharacter("Steve Buscemi", 4, 11, 12, 15);
            newChar.decreaseHealth();
            newChar.decreaseHealth();
            newChar.increaseDexterity();
            newChar.increaseIntelligence();

            newChar.Print();

        }
    }
}
