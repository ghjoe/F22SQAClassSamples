using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class BasicCalculator
    {
        public int Add(int op1, int op2)
        {
            return op1 + op2;
        }

        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divisor argument error - Can't divide by zero");
            return dividend / divisor;
        }

    }
}
