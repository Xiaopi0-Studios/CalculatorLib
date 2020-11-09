using System;
using Xiaopi0Studios.Libs;

namespace Xiaopi0Studos.LibTesters
{
    class CalculatorLibTester
    {
        static void Main(string[] args)
        {
            CalculatorLib CLib = new CalculatorLib();
            int test = CLib.InputInt("test");
            Console.WriteLine(test);
        }
    }
}
