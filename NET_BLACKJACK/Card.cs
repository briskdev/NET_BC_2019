using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Card
    {
        // 2, 3, 4..., 10, J, Q, K, A
        string Rank { get; set; }

        // C - Clubs, D - Diamonds, S - Spades, H - Hearts
        string Suit { get; set; }

        public Card(string rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        // Returns card’s title (e.g. ‘Kārava 10’ or 'D10')
        public string GetTitle()
        {
            return Suit + Rank;
        }

        // Returns card’s value (11 for Ace, 10 for face cards, numeric value for others)
        public int GetPoints()
        {
            switch(Rank)
            {
                case "A":
                    return 11;
                case "K":
                case "Q":
                case "J":
                    return 10;
                default:
                    return int.Parse(Rank);
            }
        }
    }
}
