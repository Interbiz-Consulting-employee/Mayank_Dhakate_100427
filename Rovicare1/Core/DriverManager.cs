using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.Utilities
{
    public static class DriverManager
    {
        public static IWebDriver GetDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");

            return new ChromeDriver(options);
        }

        internal static IWebDriver CreateDriver()
        {
            throw new NotImplementedException();
        }
    }
}