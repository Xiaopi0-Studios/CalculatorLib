using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaopi0.Libs.Calculator.Multiplication
{
    public abstract class BasicMultiplication
    {
        public long basicMultiplier(int startingNumber, int[] numbers)
        {
            long result = 0;
            foreach (int currentNumber in numbers)
            {
                startingNumber = startingNumber * currentNumber;
                result = startingNumber;
            }
            return result;
        }

        public long basicMultiplierOnly2Numbers(int num1, int num2)
        {
            long result = 0;
            result = num1 * num2;
            return result;
        }
    }
}
