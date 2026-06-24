using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

public static class WaitHelper
{
    public static IWebElement WaitForElement(
        IWebDriver driver,
        By locator,
        int seconds = 10)
    {
        WebDriverWait wait =
            new WebDriverWait(
                driver,
                TimeSpan.FromSeconds(seconds));

        return wait.Until(
            d => d.FindElement(locator));
    }
}
