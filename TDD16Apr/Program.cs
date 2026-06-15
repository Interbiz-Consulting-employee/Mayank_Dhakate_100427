using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD16Apr
{
    internal class Program
    {
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);

        }
    }
}
