using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace seleniumgrid
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MultiBrowserTests
    {
        private IWebDriver? driver;

        public IWebDriver CreateDriver(string browserName)
        {
            if (browserName == "chrome")
            {
                var options = new ChromeOptions();
                options.AddArgument("--start-maximized");

                return new RemoteWebDriver(
                    new Uri("http://localhost:4444"),
                    options
                );
            }

            if (browserName == "firefox")
            {
                var options = new FirefoxOptions();

                return new RemoteWebDriver(
                    new Uri("http://localhost:4444"),
                    options
                );
            }

            throw new ArgumentException("Unsupported browser: " + browserName);
        }

        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                driver?.Quit();
            }
            finally
            {
                driver?.Dispose();
                driver = null;
            }
        }

        [TestCase("chrome")]
        [TestCase("firefox")]
        public void OpenGoogle(string browserName)
        {
            driver = CreateDriver(browserName);

            driver.Navigate().GoToUrl("https://www.google.com");

            Assert.That(driver.Title, Does.Contain("Google"));
        }
        //[OneTimeTearDown]
        //public void GlobalCleanup()
        //{
        //    Console.WriteLine("All tests finished");
        //}
    }
}