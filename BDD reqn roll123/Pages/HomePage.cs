using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class HomePage
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public HomePage(IWebDriver driver)
    {
        this.driver = driver;
        this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    // Example locator usage (extendable)
    private By titleLocator = By.TagName("title");

    public string GetTitle()
    {
        return driver.Title;
    }

    public string GetPageTitleWithWait()
    {
        wait.Until(d => d.Title.Length > 0);
        return driver.Title;
    }
}