using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;

[Binding]
public class TestHooks
{
    public static IWebDriver Driver;

    [BeforeScenario]
    public void Setup()
    {
        Driver = new ChromeDriver();
        Driver.Manage().Window.Maximize();

        Console.WriteLine("Browser started");
    }

    [AfterScenario]
    public void TearDown()
    {
        System.Threading.Thread.Sleep(3000);

        Driver.Quit();
        Driver = null;

        Console.WriteLine("Browser closed");
    }
}