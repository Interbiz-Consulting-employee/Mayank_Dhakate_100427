using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



[assembly: Parallelizable(ParallelScope.All)]
namespace SeleniumTDD
{

    public class ParallelTests
    {
        [SetUp]
        public void Setup()
        {
            IWebDriver driver = new ChromeDriver();
        }
        [Test]// annotation
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.Quit();
        }

        [Test]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.flipkart.com/");
            driver.Quit();
        }
        //[Test]
        //// public void GoogleTitle_Should_Fail()
        // {
        //     IWebDriver driver.Navigate().GoToUrl("https://www.google.com");

        //     // ? Intentionally wrong assertion
        //     Assert.AreEqual("Facebook", driver.Title);
        // }
    }
}