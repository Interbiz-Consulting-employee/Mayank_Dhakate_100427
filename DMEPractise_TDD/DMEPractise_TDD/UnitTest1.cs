using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DMEPractise_TDD
{
    public class Tests
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        ChromeDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://testportal.dmescripts.com/");
            Thread.Sleep(10000);
        }

        [Test]
        public void Test1()
        {

            driver.FindElement(By.Id("signInName")).SendKeys("julyproviderhcp@yopmail.com");
            driver.FindElement(By.Id("password")).SendKeys("Test@123");
            driver.FindElement(By.Id("next")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(d => d.FindElement(By.XPath("//button[text()='Allow']")).Displayed);

            driver.FindElement(By.XPath("//button[text()='Allow']")).Click();
            Thread.Sleep(20000);
            Assert.Pass();

        }


        [Test]
        public void Createorder()
        {
            driver.FindElement(By.XPath("//*[normalize-space()='Create Order']")).Click(); Thread.Sleep(3000);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
    