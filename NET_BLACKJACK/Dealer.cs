using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    public class Dealer : BasePlayer
    {
        private const string DEALER_NAME = "Mr. Dealer";

        public override string GetName()
        {
            // Return dealer’s name (constant)
            return DEALER_NAME;
        }

        public override bool WantCard()
        {
            // If dealer has at least 17 points, return false, otherwise - true

            return CountPoints() < 17;           
            //if(CountPoints() >= 17)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
        }
    }
}
