using NUnit.Framework;

namespace Testbeforecode
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(8, result);
        }
    }
}
namespace Testbeforecode
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}