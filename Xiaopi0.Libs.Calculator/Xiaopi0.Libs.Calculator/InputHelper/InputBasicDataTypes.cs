using System;
using System.Collections.Generic;
using System.Text;

namespace Xiaopi0.Libs.Calculator.InputHelper
{
    public abstract class InputBasicDataTypes
    {
        public int InputInt(string printToConsole)
        {
            Console.Write(printToConsole);
            int inputResult = Convert.ToInt32(Console.ReadLine());
            return inputResult;
        }
    }
}
