using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_2Plus3_ShouldReturn5()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [Test]
        public void Add_0Plus0_ShouldReturn0()
        {
            Assert.AreEqual(0, calc.Add(0, 0));
        }

        [Test]
        public void Subtract_3Minus2_ShouldReturn1()
        {
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [Test]
        public void Subtract_0Minus5_ShouldReturnMinus5()
        {
            Assert.AreEqual(-5, calc.Subtract(0, 5));
        }

        [Test]
        public void Divide_4By2_ShouldReturn2()
        {
            Assert.AreEqual(2, calc.Divide(4, 2));
        }

        [Test]
        public void Divide_ByZero_ShouldThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(4, 0));
        }
    }

    public class Calculator
    {
       // public int Add(int a, int b) => a + b;
        public int Add(int a, int b) => a + b + 1; // ❌ TEMP: make test fail

        public int Subtract(int a, int b) => a - b;

        public int Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            return a / b;
        }
    }
}