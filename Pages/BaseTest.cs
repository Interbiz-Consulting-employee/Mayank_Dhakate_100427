using NUnit.Framework;
using OpenQA.Selenium;
using AutomationFramework.Utilities;

public class BaseTest
{
    protected IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = DriverManager.GetDriver();

        driver.Navigate().GoToUrl(
            ConfigReader.BaseUrl);

        HandleNotificationPopup();
    }

    private void HandleNotificationPopup()
    {
        try
        {
            driver.FindElement(
                By.XPath("//button[contains(text(),'Allow')]"))
                .Click();
        }
        catch
        {
            Console.WriteLine("Popup not present");
        }
    }

    [TearDown]
    public void TearDown()
    {
        if (driver != null)
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}