using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelpers
{
    public abstract class BaseConsoleReader<T>
    {
        protected abstract bool CheckValue(string input, out T value);

        public T GetValue(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (CheckValue(input, out T value))
            {
                return value;
            }
            else
            {
                Console.WriteLine("Invalid value!");
                return GetValue(message);
            }
        }
    }
}
