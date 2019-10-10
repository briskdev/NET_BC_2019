using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        private int CurrentNumber; // current number player guesses
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;

        public void StartNewGame()
        {
            //1.Generate a new random number(1 – 500) and set it as ‘CurrentNumber’;
            CurrentNumber = new Random().Next(1, 501);
            //2.Create PlayerOne and PlayerTwo:
            //2.1.PlayerOne as User;
            PlayerOne = new User();
            //2.2.PlayerTwo as Robot.
            PlayerTwo = new Robot();
        }

        public void Loop()
        {
            //1. Main game loop which contains PlayerOne turn and then PlayerTwo turn:
            while(true)
            {
                Console.WriteLine("Player one turn: ");
                if(PlayerTurn(PlayerOne))
                {
                    break;
                }

                Console.WriteLine("Player two turn: ");
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }
            }
        }

        private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool isGuessed = player.IsNumberGuessed(CurrentNumber);

            if(isGuessed)
            {
                Console.WriteLine("Player {0} wins!", player.GetName());
            }

            return isGuessed;
        }
    }
}
