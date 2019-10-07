using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    abstract class BasePlayer : IPlayer
    {
        public string Name { get; set; }

        public int CurrentGuess { get; set; }

        public BasePlayer()
        {

        }

        public abstract string GetName();

        public abstract int GuessNumber();

        public virtual bool IsNumberGuessed(int number)
        {
            throw new NotImplementedException();
        }
    }
}
