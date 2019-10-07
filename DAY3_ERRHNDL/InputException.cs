using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_ERRHNDL
{
    class InputException : Exception
    {
        public InputException(string message)
            :base(message)
        {

        }
    }
}
