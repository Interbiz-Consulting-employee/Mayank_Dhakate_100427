using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    By username = By.Id("username");
    By password = By.Id("password");
    By loginBtn = By.Id("loginBtn");

    public void Login(string user, string pass)
    {
        driver.FindElement(username).SendKeys(user);
        driver.FindElement(password).SendKeys(pass);
        driver.FindElement(loginBtn).Click();
    }
}