namespace Flipkart_Automation;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class Program
    {
        static void Main(string[] args)
        {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.amazon.com/");
        driver.Manage().Window.Maximize();
        Thread.Sleep(5000);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        try
        {
            IAlert alert = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            Console.WriteLine(alert.Text);
            alert.Accept();
        }
        catch (WebDriverTimeoutException)
        {
            Console.WriteLine("Alert not present within timeout");
        }
        // driver.FindElement(By.XPath("//div[starts-with(text(),'Continue shopping')]")).Click();
        IWebElement search = driver.FindElement(By.Id("twotabsearchtextbox"));
        search.SendKeys("Iphone");
        driver.FindElement(By.Id("nav-search-submit-button")).Click();
        driver.FindElement(By.XPath("//img[@alt='Apple iPhone 16 Pro Max, US Version, 256GB, Desert Titanium - Unlocked (Renewed)']")).Click();
        Thread.Sleep(10000);
        driver.Quit();
    }
}

