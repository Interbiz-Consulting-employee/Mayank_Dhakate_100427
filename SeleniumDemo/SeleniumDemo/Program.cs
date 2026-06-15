using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace SeleniumDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Initialize Chrome driver
            //using ChromeDriver driver = new ChromeDriver();

            // Step 2: Open a URL
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");

            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            //IWebElement name = driver.FindElement(By.XPath("//input[@placeholder='Enter Name']"));    //By relative xpath
            //  name.SendKeys("Mayank");
            //IWebElement Entername = driver.FindElement(By.Id("name"));  //By Id
            //Entername.SendKeys("Mayank");
            IWebElement EnterName= driver.FindElements(By.ClassName("form-control"))[0];
            EnterName.SendKeys("Mayank");
            Thread.Sleep(2000);
            // Step 3: Print page title
            //Console.WriteLine("Page title is: " + driver.Title);

            // Step 4: Close browser
            driver.Quit();
        }

    }
}
