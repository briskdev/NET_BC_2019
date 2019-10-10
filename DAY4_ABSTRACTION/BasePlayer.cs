using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BasePlayer : IPlayer
    {
        /// <summary>
        /// 
        /// </summary>
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        public BasePlayer()
        {
            // 1. Constructor that sets ‘Name’ as GetName() returned string
            Name = GetName();
        }

        // 1. Abstract method without body.
        public abstract string GetName();

        // 1. Abstract method without body.
        public abstract int GuessNumber();

        /// <summary>
        /// Metodes apraksts
        /// </summary>
        /// <param name="number">Parametra number apraksts</param>
        /// <returns>Ko metode atgriež?</returns>
        public virtual bool IsNumberGuessed(int number)
        {
            // 1. Checks and returns bool result if ‘number’ is equal ‘CurrentGuess’
            if(number > CurrentGuess)
            {
                Console.WriteLine("{0} is less then number!", CurrentGuess);
                NextGuess = 1;
            }
            else if(number < CurrentGuess)
            {
                Console.WriteLine("{0} is greater then number!", CurrentGuess);
                NextGuess = -1;
            }

            return number == CurrentGuess;
        }
    }
}
