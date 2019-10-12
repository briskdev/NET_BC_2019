using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Deck
    {
        // 4 masti
        string[] suits = new[] { "C", "S", "D", "H" };
        // 13 rangi
        string[] ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        List<Card> Cards;

        // Creates and a new list of cards (List<Card>). 
        // Fills list with all 52 cards (4 suits and 13 ranks)
        public Deck()
        {
            Cards = new List<Card>();
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }

        // Randomly orders (shuffles) the list of cards
        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }

        // Takes the last card from the list. 
        // Removes it from the list. 
        // Returns it.
        public Card GetCard()
        {
            Card card = Cards.Last();
            Cards.Remove(card);

            return card;
        }
    }
}
