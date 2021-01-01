using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaopi0.Libs.Calculator.Division
{
    class BasicDivision
    {
        public int basicDivider(int startingNumber, int[] numbers)
        {
            int result = 0;
            int holder = 0;
            foreach (int currentNumber in numbers)
            {
                holder = startingNumber / currentNumber;
                result = holder;
            }
            result = holder;
            return result;
        }

        public int basicDividerOnly2Numbers(int num1, int num2)
        {
            int result;
            result = num1 / num2;
            return result;
        }
    }
}
