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

        public static bool GetBool(string message)
        {
            string answer = GetText(message).ToLower();

            return answer == "y" || answer == "yes";
            //if (answer == "y" || answer == "yes")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
