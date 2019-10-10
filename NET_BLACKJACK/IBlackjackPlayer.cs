using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public interface IBlackjackPlayer
    {
        // Returns player’s name
        string GetName();

        // Returns player’s cards in hand
        List<Card> GetCards();

        // Counts total points of player’s cards
        int CountPoints();

        // Checks if player’s points is over 21
        bool IsGameCompleted();

        // Checks if player wants another card
        bool WantCard();

        // Player receives a new card from the deck. Adds card to player’s hand.
        void GiveCard(Card card);
    }
}
