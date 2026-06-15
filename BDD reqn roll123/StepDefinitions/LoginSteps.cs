using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System.Threading;

[Binding]
public class LoginSteps
{
    private IWebDriver driver;

    [Given("I open the browser")]
    public void GivenIOpenTheBrowser()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [When("I navigate to {string}")]
    public void WhenINavigateTo(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    [When("I login with following credentials")]
    public void WhenILoginWithFollowingCredentials(Table table)
    {
        foreach (var row in table.Rows)
        {
            string username = row["username"];
            string password = row["password"];

            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("username")).SendKeys(username);

            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys(password);

            driver.FindElement(By.XPath("//button[text()='Login']")).Click();

            Thread.Sleep(2000); // only for demo (not recommended in real framework)
        }
    }

    [Then("login should be attempted for all users")]
    public void ThenLoginShouldBeAttemptedForAllUsers()
    {
        driver.Quit();
    }
}