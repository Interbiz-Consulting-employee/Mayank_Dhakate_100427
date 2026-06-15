using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorAnnotationsTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [TearDown]
        public void Cleanup()
        {
            calc = null;
        }

        [Test]
        [Category("Addition")]
        public void Add_5Plus7_ShouldReturn12()
        {
            Assert.AreEqual(12, calc.Add(5, 7));
        }

        [Test]
        [Category("Subtraction")]
        public void Subtract_10Minus4_ShouldReturn6()
        {
            Assert.AreEqual(6, calc.Subtract(10, 4));
        }

        [Test]
        [Category("Division")]
        public void Divide_ByZero_ShouldThrow()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(10, 0));
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }
}