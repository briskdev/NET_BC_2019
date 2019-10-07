using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    interface IPlayer
    {
        int GuessNumber();

        bool IsNumberGuessed(int number);

        string GetName();
    }
}
