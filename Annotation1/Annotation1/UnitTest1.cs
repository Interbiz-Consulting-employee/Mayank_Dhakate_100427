using NUnit.Framework;

namespace TDDDemo
{
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
        // MULTIPLY TEST (Passable)
        // -----------------------------
        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            int result = _calculator.Multiply(3, 4);
            Assert.AreEqual(12, result);
        }

        // -----------------------------
        // ADD TEST (Red Stage) - Initially Fail
        // -----------------------------
        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            int result = _calculator.Add(5, 7);

            // 🔴 Red Stage: Temporary failing assertion
            // Use a wrong expected value to show fail
            Assert.AreEqual(999, result, "This test is designed to fail initially (Red Stage).");
        }
    }

    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Add(int a, int b)
        {
            return a + b; // Initially correct logic, but test fails because of wrong expected value
        }
    }
}