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
            // RED STAGE
            // throw new NotImplementedException();

            //REFACTOR - argument checks
            if (divisor == 0)
                throw new ArgumentException("Divisor argument error - Can't divide by zero");

            // GREEN STAGE - minimum amount of code for test to pass
            return dividend / divisor;
        }

        public int Multiply(int v1, int v2)
        {
            // RED STATE
            // throw new NotImplementedException();

            // GREEN STATE
            return v1 * v2;

            // REFACTOR STATE - SKIP AS THERE IS NOT ELSE WE CAN DO
        }
    }
}
