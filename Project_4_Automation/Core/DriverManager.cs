using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationFramework.Utilities
{
    public static class DriverManager
    {
        private static IWebDriver driver;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }

            return driver;
        }

        public static void QuitDriver()
        {
            driver?.Quit();
            driver = null;
        }
    }
}