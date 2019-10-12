using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;

        public void StartNewGame()
        {
            // Create players - dealer and player.
            PlayerOne = new Player();
            PlayerTwo = new Dealer();
            // Create a new card deck. Shuffle it.
            Deck = new Deck();
            Deck.Shuffle();
            // Take two cards from the deck and give it to player.
            PlayerOne.GiveCard(Deck.GetCard());
            PlayerOne.GiveCard(Deck.GetCard());
            // Take two cards from the dek and give it to dealer.
            PlayerTwo.GiveCard(Deck.GetCard());
            PlayerTwo.GiveCard(Deck.GetCard());
        }

        public void Loop()
        {
            // Give player a new card from the deck while his points 
            // are not over 21 and he wants another card.
            while(!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                PlayerOne.GiveCard(Deck.GetCard());
            }

            // If player’s points are over 21, player loses, 
            // otherwise - dealer’s turn.
            if(PlayerOne.CountPoints() > 21)
            {
                Console.WriteLine("You lose!");
            }
            else if(PlayerOne.CountPoints() == 21)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Dealer turn: ");
                // Give dealer a new card from the deck while his points 
                // are not over 21 and he wants another card.
                while (!PlayerTwo.IsGameCompleted() && PlayerTwo.WantCard())
                {
                    PlayerTwo.GiveCard(Deck.GetCard());
                }

                // Output points for both players.
                int playerPoints = PlayerOne.CountPoints();
                int dealerPoints = PlayerTwo.CountPoints();
                Console.WriteLine("Your points: {0}", playerPoints);
                Console.WriteLine("Dealer points: {0}", dealerPoints);

                // If dealer’s points are over 21, player wins, 
                // otherwise check who was closer to 21.

                Console.WriteLine(dealerPoints > 21 || playerPoints > dealerPoints 
                    ? "You win!" 
                    : "You lose!");
            }
        }
    }
}
