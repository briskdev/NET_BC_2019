using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    abstract class BasePlayer : IPlayer
    {
        public string Name;
        public int CurrentGuess;

        public BasePlayer()
        {
            // 1. Constructor that sets ‘Name’ as GetName() returned string
            Name = GetName();
        }

        // 1. Abstract method without body.
        public abstract string GetName();

        // 1. Abstract method without body.
        public abstract int GuessNumber();

        public virtual bool IsNumberGuessed(int number)
        {
            // 1. Checks and returns bool result if ‘number’ is equal ‘CurrentGuess’
            return number == CurrentGuess;
        }
    }
}
