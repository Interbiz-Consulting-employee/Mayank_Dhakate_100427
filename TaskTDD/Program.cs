using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TaskTDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.Quit();
        }
    }
}