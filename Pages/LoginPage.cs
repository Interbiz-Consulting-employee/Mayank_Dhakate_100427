using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private By username =
        By.XPath("//input[contains(@id,'signInName')]");

    private By password =
        By.Id("password");

    private By loginBtn =
        By.Id("next");

    private By settingIcon =
        By.XPath("//*[contains(@class,'dme-admin-settings-icon')]");

    private By organizationBtn =
        By.XPath("//button[normalize-space()='Organization']");

    private By organizationTypeDropdown =
        By.XPath("//mat-select[@name='organizationType']");
    private By healthcareProviderOption =
    By.XPath("//mat-option//span[normalize-space()='HealthCareProvider']");

    public void Login(string user, string pass)
    {
        // Login
        WaitHelper.WaitForElement(driver, username, 20)
            .SendKeys(user);

        WaitHelper.WaitForElement(driver, password, 20)
            .SendKeys(pass);

        WaitHelper.WaitForElement(driver, loginBtn, 20)
    .Click();

        Thread.Sleep(15000);

        Console.WriteLine("Current URL: " + driver.Url);
        Console.WriteLine("Page Title: " + driver.Title);

        // Check if settings icon exists
        var settings = driver.FindElements(
            By.XPath("//*[contains(@class,'dme-admin-settings-icon')]"));

        Console.WriteLine("Settings Count = " + settings.Count);

        // Browser ko 30 sec khula rakho
        Thread.Sleep(30000);
        // Click Organization Button
        WaitHelper.WaitForElement(driver, organizationBtn, 20)
            .Click();

        Thread.Sleep(3000);

        // Select 2nd Organization Type
        SelectOrganizationType();
    }

    public void SelectOrganizationType()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));

        // Open dropdown
        IWebElement dropdown = wait.Until(d =>
        {
            var element = d.FindElement(organizationTypeDropdown);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        dropdown.Click();

        Thread.Sleep(2000);

        // Click HealthCareProvider option
        IWebElement option = wait.Until(d =>
        {
            var element = d.FindElement(
                By.XPath("//mat-option//span[normalize-space()='HealthCareProvider']"));

            return (element.Displayed && element.Enabled) ? element : null;
        });

        option.Click();

        Thread.Sleep(20000);
    }

}