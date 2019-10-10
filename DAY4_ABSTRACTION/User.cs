using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class User : BasePlayer
    {
        public override string GetName()
        {
            if(!String.IsNullOrEmpty(Name))
            {
                return Name;
            }

            return ConsoleInput.GetText("Enter your name: ");
        }

        public override int GuessNumber()
        {
            CurrentGuess = ConsoleInput.GetInt("Enter your guess: ");

            return CurrentGuess;
        }
    }
}
