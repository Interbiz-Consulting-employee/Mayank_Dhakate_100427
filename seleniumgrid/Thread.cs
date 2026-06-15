using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace seleniumgrid
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class MultiBrowserThreadSafeTests
    {
        private ThreadLocal<IWebDriver> driver = new();

        private IWebDriver CreateDriver(string browserName)
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
            if (driver.IsValueCreated)
            {
                driver.Value.Quit();
                driver.Value.Dispose();
            }
        }

        [TestCase("chrome")]
        [TestCase("firefox")]
        public void OpenGoogle(string browserName)
        {
            driver.Value = CreateDriver(browserName);

            driver.Value.Navigate().GoToUrl("https://www.google.com");

            Assert.That(driver.Value.Title, Does.Contain("Google"));
        }
    }
}