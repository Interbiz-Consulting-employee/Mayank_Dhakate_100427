using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;

[Binding]
public class TestHooks
{
    public static IWebDriver Driver;

    [BeforeScenario]
    public void Setup()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();

        Console.WriteLine("Browser Started");
    }

    [AfterScenario]
    public void TearDown()
    {
        Thread.Sleep(3000); // SEE UI

        Driver.Quit();
        Driver = null;

        Console.WriteLine("Browser Closed");
    }
}