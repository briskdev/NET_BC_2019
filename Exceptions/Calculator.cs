using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Calculator
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Divide(int num1, int num2)
        {
            // rules
            if(num2 == 0)
            {
                throw new CalculatorException("Nevar dalīt ar 0!");
            }

            // execution
            return (decimal)num1 / num2;
        }
    }
}
