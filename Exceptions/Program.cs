using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                int num1 = GetNumber("Enter number A: ");
                int num2 = GetNumber("Enter number B: ");

                Console.WriteLine("Division = {0}", 
                    Calculator.Divide(num1, num2));
            }
            catch(CalculatorException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Neparedzēta kļūda!");
            }

            Console.Read();
        }

        static int GetNumber(string text)
        {
            Console.Write(text);
            string input = Console.ReadLine();

            try
            {
                int result = int.Parse(input);
                return result;
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number!");
                return GetNumber(text);
            }
        }
    }
}
