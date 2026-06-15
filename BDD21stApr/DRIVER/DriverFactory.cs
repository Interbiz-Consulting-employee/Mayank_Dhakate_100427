using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BDD_Framework.Drivers
{
    public class DriverFactory
    {
        public static IWebDriver CreateDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            return new ChromeDriver(options);
        }
    }
}