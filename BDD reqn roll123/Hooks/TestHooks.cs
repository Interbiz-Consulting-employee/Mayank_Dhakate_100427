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
        ChromeOptions options = new ChromeOptions();

        // IMPORTANT: ensures UI is visible
        options.AddArgument("--start-maximized");

        Driver = new ChromeDriver(options);

        Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    }

    [AfterScenario]
    public void TearDown()
    {
        if (Driver != null)
        {
            Thread.Sleep(2000); // only for debugging visibility
            Driver.Quit();
            Driver = null;
        }
    }
}