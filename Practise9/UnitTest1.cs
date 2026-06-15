using NUnit.Framework;

namespace AnnotationDemo
{
    public class DemoTests
    {
        private int Add(int a, int b)
        {
            return a + b;
        }

        //  CASE 1: WITH [Test]
        [Test]
        public void Test_WithAttribute()
        {
            Assert.AreEqual(7, Add(2, 5));
        }

        //  CASE 2: WITHOUT [Test]
        public void Test_WithoutAttribute()
        {
            Assert.AreEqual(5, Add(2, 3));
        }

        //  CASE 3: WITH TestCase
        [TestCase(1, 1, 2)]
        [TestCase(2, 3, 5)]
        public void Test_WithTestCase(int a, int b, int expected)
        {
            Assert.AreEqual(expected, Add(a, b));
        }

        // CASE 4: WITHOUT TestCase (normal method)
        public void Test_NormalMethod(int a, int b, int expected)
        {
            Assert.AreEqual(expected, Add(a, b));
        }
    }
}