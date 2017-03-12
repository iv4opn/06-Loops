using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Cards
{
    static void Main(string[] args)
    {
        string[] colors = new string[4] { "Spades", "Diamonds", "Hearts", "Clubs" };
        string[] cards = new string[13]{"Ace of", "Two of", "Three of", "Four of", "Five of", "Six of", "Seven of", "Eight of", "Nine of",
                "Ten of", "Jack of", "Queen of", "King of"};

        for (int color = 1; color < colors.Length; color++)
        {
            for (int card = 2; card < cards.Length; card++)
            {
                Console.WriteLine(cards[card] + " " + colors[color]);
            }
            Console.WriteLine();

        }
    }
}
