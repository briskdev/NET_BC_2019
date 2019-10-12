using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Player : BasePlayer
    {
        public override string GetName()
        {
            // If player’s name is defined return it, otherwise ask for user’s name, store it and return it
            if(!String.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return ConsoleInput.GetText("Enter your name: ");
        }

        public override bool WantCard()
        {
            return ConsoleInput.GetBool("Another card? ");
        }

        public override void GiveCard(Card card)
        {
            base.GiveCard(card);

            Console.WriteLine("You received card: {0}", card.GetTitle());
            Console.WriteLine("Your points: {0}", CountPoints());
        }
    }
}
