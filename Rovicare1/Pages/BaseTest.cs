using AutomationFramework.Utilities;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Project4.Reports;
using System;

namespace AutomationFramework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            ExtentManager.InitReport();
        }

        [SetUp]
        public void Setup()
        {
            driver = DriverManager.GetDriver();

            driver.Manage().Window.Maximize();

            string testName = TestContext.CurrentContext.Test.Name;

            string url = ConfigReader.GetBaseUrl(testName);

            if (string.IsNullOrEmpty(url))
                throw new Exception($"URL is null for test: {testName}");

            driver.Navigate().GoToUrl(url);

            // ⭐ IMPORTANT: attach driver to ExtentManager for screenshots
            ExtentManager.SetDriver(driver);

            ExtentManager.CreateTest(testName);

            HandleNotificationPopup();
        }

        private void HandleNotificationPopup()
        {
            try
            {
                var popup = driver.FindElement(
                    By.XPath("//button[contains(text(),'Allow')]"));

                if (popup.Displayed && popup.Enabled)
                {
                    popup.Click();
                }
            }
            catch
            {
                Console.WriteLine("Notification popup not present");
            }
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                var status = TestContext.CurrentContext.Result.Outcome.Status;
                var message = TestContext.CurrentContext.Result.Message;

                switch (status)
                {
                    case TestStatus.Passed:
                        ExtentManager.LogPass("Test Passed");
                        break;

                    case TestStatus.Failed:
                        ExtentManager.LogFail(message ?? "Test Failed");
                        break;

                    case TestStatus.Skipped:
                        ExtentManager.LogSkip("Test Skipped");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Extent logging error: " + ex.Message);
            }
            finally
            {
                try
                {
                    driver?.Quit();
                    driver?.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Driver cleanup error: " + ex.Message);
                }
            }
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            try
            {
                ExtentManager.FlushReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Extent flush error: " + ex.Message);
            }
        }
    }
}