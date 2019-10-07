using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Game
    {
        int CurrentNumber; // current number player guesses
        IPlayer PlayerOne;
        IPlayer PlayerTwo;

        public void StartNewGame()
        {
            // generates new random number
        }

        public void Loop()
        {
            // main game logic
        }

        public void PlayerTurn(IPlayer player)
        {
            // player move
        }
    }
}
