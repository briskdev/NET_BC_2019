using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_BLACKJACK
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                // Create a new game, start it and call game loop
                // Ask if user would like to play another round
                Game game = new Game();

                while(true)
                { 
                    game.StartNewGame();
                    game.Loop();

                    if(!ConsoleInput.GetBool("Play again? "))
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
            Console.Read();
        }
    }
}
