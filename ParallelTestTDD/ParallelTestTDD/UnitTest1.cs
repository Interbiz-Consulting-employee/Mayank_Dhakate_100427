using NUnit.Framework;
using System.Threading;

namespace TDDDemo
{
    // ================================
    // TEST CLASS
    // ================================
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // -----------------------------
        // MULTIPLY TEST (Always Pass)
        // -----------------------------
        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = _calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        // -----------------------------
        // ADD TEST (Initially FAILS) → Red Stage
        // -----------------------------
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = _calculator.Add(5, 7);

            // 🔴 Red Stage: Wrong expected value to show fail
            Assert.AreEqual(999, result, "This test is designed to fail initially (Red Stage).");
        }

        // -----------------------------
        // MULTIPLE PARALLEL TESTS
        // -----------------------------
        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void Multiply_Parallel_Test1()
        {
            Thread.Sleep(500);
            Assert.AreEqual(6, _calculator.Multiply(2, 3));
        }

        [Test]
        [Parallelizable(ParallelScope.Self)]
        public void Multiply_Parallel_Test2()
        {
            Thread.Sleep(500);
            Assert.AreEqual(20, _calculator.Multiply(4, 5));
        }
    }

    // ================================
    // CODE CLASS
    // ================================
    public class Calculator
    {
        // Multiply method
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        // Add method
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}