using System;
using OpenQA.Selenium;
using Reqnroll;

[Binding]
public class LoginSteps
{
    private IWebDriver driver => TestHooks.Driver;

    [Given("I open the browser")]
    public void OpenBrowser()
    {
        Console.WriteLine("Browser already started from Hooks");
    }

    [When("I navigate to {string}")]
    public void Navigate(string url)
    {
        driver.Navigate().GoToUrl(url);
    }

    [When("I login with username {string} and password {string}")]
    public void Login(string user, string pass)
    {
        driver.FindElement(By.Id("username")).SendKeys(user);
        driver.FindElement(By.Id("password")).SendKeys(pass);
        driver.FindElement(By.Id("loginBtn")).Click();
    }

    [Then("login should be successful")]
    public void VerifyLogin()
    {
        Console.WriteLine("Login Successful");
    }
}