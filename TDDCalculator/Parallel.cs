using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCalculator
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]

    public class CalculatorTests
    {
        Calculator1 calc = new Calculator();

        [Test]
        public void Test_Add_1()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [Test]
        public void Test_Add_2()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(7, calc.Add(3, 4));
        }

        [Test]
        public void Test_Add_3()
        {
            Thread.Sleep(2000);
            Assert.AreEqual(10, calc.Add(5, 5));
        }
    }
}
