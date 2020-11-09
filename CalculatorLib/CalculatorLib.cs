using System;

namespace Xiaopi0Studios.Libs
{
    public class CalculatorLib
    {
        public int InputInt(string printToConsole)
        {
            Console.Write(printToConsole);
            int inputResult = Convert.ToInt32(Console.ReadLine());
            return inputResult;
        }

        public long add(int[] numbers)
        {
            long result = 0;
            foreach (int currentNumber in numbers)
            {
                result = result + currentNumber;
            }
            return result;
        }

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

        #region Multiplication
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
        #endregion

        #region Division
        public int basicDividerOnly2Numbers(int num1, int num2)
        {
            int result;
            result = num1 / num2;
            return result;
        }

        public int basicDivider(int startingNumber, int[] numbers)
        {
            int result = 0;
            int holder = 0;
            foreach(int currentNumber in numbers)
            {
                holder = startingNumber / currentNumber;
                result = holder;
            }
            result = holder;
            return result;
        }
        #endregion
    }
}
