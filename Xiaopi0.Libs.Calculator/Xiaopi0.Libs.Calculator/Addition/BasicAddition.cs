using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaopi0.Libs.Calculator.Addition
{
    public abstract class BasicAddition
    {
        public long add(int[] numbers)
        {
            long result = 0;
            foreach (int currentNumber in numbers)
            {
                result = result + currentNumber;
            }
            return result;
        }
    }
}
