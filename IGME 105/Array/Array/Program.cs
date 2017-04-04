using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Deck deck = new Deck();
                Console.Write("Enter the number of cards to deal: ");
                int userCards = int.Parse(Console.ReadLine());

                if (userCards > 52 || userCards < 1)
                {
                    Console.WriteLine("Invalid number. Enter a number 1 - 52");
                    continue;
                }
                else
                {
                    deck.Deal(userCards);
                    break;
                }
            }

        }
    }
}
