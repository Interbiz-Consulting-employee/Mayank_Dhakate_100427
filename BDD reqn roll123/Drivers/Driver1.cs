using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDD_reqn_roll123
{
    public class DriverManager
    {
        public static IWebDriver Driver;

        public static void Initialize()
        {
            var options = new ChromeOptions();

            options.AddArgument("--start-maximized");
            options.AddArgument("--disable-notifications");
            options.AddArgument("--incognito");

            Driver = new ChromeDriver(options);

            Driver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(10);
        }

        public static void Quit()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }
    }
}