using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Card
    {
        public int value;
        public String suit;

        public Card(int value, String suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public void Print()
        {
            if(value == 1)
            {
                Console.Write("Ace of " + suit);
                Console.WriteLine();
            }
            else if (value == 13)
            {
                Console.Write("King of " + suit);
                Console.WriteLine();
            }
            else if (value == 12)
            {
                Console.Write("Queen of " + suit);
                Console.WriteLine();
            }
            else if (value == 11)
            {
                Console.Write("Jack of " + suit);
                Console.WriteLine();
            }
            else
            {
                Console.Write(value + " of " + suit);
                Console.WriteLine();
            }
        }
        
    }
}
