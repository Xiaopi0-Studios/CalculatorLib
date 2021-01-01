using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaopi0.Libs.Calculator.Subtraction
{
    public abstract class BasicSubtraction
    {
        public int subtract(int startingNumber, int[] numbers)
        {
            int result = 0;
            foreach (int currentNumber in numbers)
            {
                startingNumber = startingNumber - currentNumber;
                result = startingNumber;
            }
            return result;
        }
    }
}
