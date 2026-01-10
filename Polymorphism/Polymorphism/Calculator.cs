using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Calculator
    {
        public virtual void Calci(int a, int b)
        {
            Console.WriteLine("Sum is" + a + b);
        }
        public void Calci(string s)
        {
            Console.WriteLine("Hi"+ s+ "calculator is ruuning");
        }
    }
    class Advancecalci : Calculator
    {
        public override void Calci(int a, int b)
        {
            Console.WriteLine("Multiplication is"+ (a*b));
        }
    }
}
