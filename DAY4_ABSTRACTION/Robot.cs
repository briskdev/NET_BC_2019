using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Robot : BasePlayer
    {
        public override string GetName()
        {
            //1. Returns text “R0B0T”.
            return "R0B0T";
        }

        public override int GuessNumber()
        {
            //1.Generate random number from 1 to 500 and store it as ‘CurrentGuess’;
            CurrentGuess = new Random().Next(1, 501);

            //2.Return generated number.
            return CurrentGuess;
        }
    }
}
