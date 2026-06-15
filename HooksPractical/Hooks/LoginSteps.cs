using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using SeleniumExtras.WaitHelpers;

[Binding]
public class LoginSteps
{
    private readonly DriverContext _context;

    public LoginSteps(DriverContext context)
    {
        _context = context;
    }

    [Given(@"user is on login page")]
    public void GivenUserIsOnLoginPage()
    {
        _context.Driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");
    }

    [When(@"user enters ""(.*)"" and ""(.*)""")]
    public void WhenUserEntersAnd(string username, string password)
    {
        WebDriverWait wait = new WebDriverWait(_context.Driver, TimeSpan.FromSeconds(10));

        var user = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
        user.Clear();
        user.SendKeys(username);

        var pass = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
        pass.Clear();
        pass.SendKeys(password);

        wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[contains(.,'Login')]"))).Click();

        Thread.Sleep(2000);
    }
    [Then("user should see login result")]
    public void ThenUserShouldSeeLoginResult()
    {
        var wait = new WebDriverWait(_context.Driver, TimeSpan.FromSeconds(10));

        var message = wait.Until(
            ExpectedConditions.ElementIsVisible(By.CssSelector(".flash"))
        );

        Assert.That(message.Text, Does.Contain("You logged into a secure area!"));
    }
}
