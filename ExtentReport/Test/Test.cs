using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

public class BaseTest
{
    protected ThreadLocal<IWebDriver> driver = new();

    [SetUp]
    public void Setup()
    {
        driver.Value = new ChromeDriver();
        driver.Value.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Value.Quit();
        driver.Value.Dispose();
    }
}