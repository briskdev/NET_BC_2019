using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelpers
{
    public class TextReader : BaseConsoleReader<string>
    {
        protected override bool CheckValue(string input, out string value)
        {
            input = input.Trim();

            value = input;

            return !String.IsNullOrEmpty(input);
        }
    }
}
