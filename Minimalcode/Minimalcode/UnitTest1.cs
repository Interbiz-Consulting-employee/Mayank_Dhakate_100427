using NUnit.Framework;

namespace TDDDemo
{
    // ======================================
    // TEST CLASS: Yeh woh class hai jisme hum
    // pehle test likhte hain (TDD Red Stage)
    // ======================================
    [TestFixture] // NUnit ko batata hai ki yeh test class hai
    public class CalculatorTests
    {
        private Calculator _calculator;

        // -----------------------------
        // Setup method: har test se pehle run hota hai
        // -----------------------------
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        // -----------------------------
        // TEST METHOD: Multiply function test
        // -----------------------------
        [Test] // NUnit ko batata hai ki yeh ek test method hai
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Arrange: inputs
            int a = 4;
            int b = 5;

            // Act: method call
            int result = _calculator.Multiply(a, b);

            // Assert: expected vs actual
            Assert.AreEqual(20, result, "Multiply function should return product of two numbers.");
        }

        // -----------------------------
        // OPTIONAL: Ye test fail dikhata hai initially (Red stage)
        // -----------------------------
        [Test]
        public void Multiply_ByZero_ReturnsZero()
        {
            int result = _calculator.Multiply(10, 0);
            Assert.AreEqual(0, result, "Any number multiplied by 0 should be 0.");
        }
    }

    // ======================================
    // CODE CLASS: Yeh minimal code hai jo
    // test ko pass karne ke liye likha gaya (Green Stage)
    // ======================================
    public class Calculator
    {
        // Multiply method
        public int Multiply(int a, int b)
        {
            return a * b; // Minimal implementation
        }

        // Aap future me aur methods add kar sakte ho
        // jaise Add, Subtract, Divide etc.
    }
}