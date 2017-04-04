using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];

            for (int deck = 0; deck < 13; deck++)
            {
                cards[deck] = new Card(deck + 1, "Diamonds");
            }
            for (int deck = 13; deck < 26; deck++)
            {
                cards[deck] = new Card(deck - 12, "Hearts");
            }
            for (int deck = 26; deck < 39; deck++)
            {
                cards[deck] = new Card(deck - 24, "Spades");
            }
            for (int deck = 39; deck < 52; deck++)
            {
                cards[deck] = new Card(deck - 36, "Clubs");
            }

        }

        public void Deal(int numberOfCards)
        {
            Random random = new Random();
            for(int i = 0; i < numberOfCards; i++)
            {
                cards[random.Next(0, 53)].Print();
            }
        }

    }
}
