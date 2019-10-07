using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelpers
{
    class IntegerReader : BaseConsoleReader<int>
    {
        protected override bool CheckValue(string input, out int value)
        {
            return int.TryParse(input, out value);
        }
    }
}
