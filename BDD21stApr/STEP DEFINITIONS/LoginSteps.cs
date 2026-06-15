using OpenQA.Selenium;
using Reqnroll;
using System.Threading;

[Binding]
public class LoginSteps
{
    private IWebDriver driver => TestHooks.Driver;

    [Given("I open the browser")]
    public void GivenIOpenTheBrowser()
    {
        Console.WriteLine("Browser already opened from Hooks");
    }

    [When("I navigate to {string}")]
    public void WhenINavigateTo(string url)
    {
        driver.Navigate().GoToUrl(url);

        Console.WriteLine("Navigated to: " + url);

        Thread.Sleep(2000);
    }

    [When("I login with following credentials")]
    public void WhenILoginWithFollowingCredentials(Table table)
    {
        foreach (var row in table.Rows)
        {
            driver.FindElement(By.Id("username")).SendKeys(row["username"]);
            driver.FindElement(By.Id("password")).SendKeys(row["password"]);

            driver.FindElement(By.XPath("//button[text()='Login']")).Click();

            Thread.Sleep(2000);
        }
    }

    [Then("login should be attempted for all users")]
    public void ThenLoginShouldBeAttemptedForAllUsers()
    {
        Console.WriteLine("Login attempted for all users");
    }
}