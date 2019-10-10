using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public abstract class BasePlayer : IBlackjackPlayer
    {
        protected string Name { get; set; }

        protected List<Card> Cards { get; set; }

        public BasePlayer()
        {
            Cards = new List<Card>();
            Name = GetName();
        }

        // Returns player’s cards in hand
        public List<Card> GetCards()
        {
            return Cards;
        }

        // Counts total points of player’s cards. 
        // If total points is over 21 and player has ‘Ace’, 
        // remove 10 points for each Ace until points <=21 
        // or there are no more aces.
        public int CountPoints()
        {
            int points = Cards.Sum(c => c.GetPoints());

            if(points > 21)
            {
                int aceCount = Cards.Count(c => c.GetPoints() == 11);

                while(aceCount > 0 && points > 21)
                {
                    points -= 10;
                    aceCount--;
                }
            }

            return points;
        }

        // Returns true if player’s points is over 21, otherwise - false
        public bool IsGameCompleted()
        {
            return CountPoints() > 21;
        }

        // Player receives a new card from the deck. 
        // Adds card to player’s hand.
        public void GiveCard(Card card)
        {
            Cards.Add(card);
        }

        public abstract string GetName();
        public abstract bool WantCard();
    }
}
