using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelpers
{
    public class ConsoleInput
    {
        public static DateTime GetDate(string message)
        {
            return new DateReader().GetValue(message);
        }

        public static string GetText(string message)
        {
            return new TextReader().GetValue(message);
        }

        public static int GetInt(string message)
        {
            return new IntegerReader().GetValue(message);
        }
    }
}
