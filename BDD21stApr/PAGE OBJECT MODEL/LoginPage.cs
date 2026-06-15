using OpenQA.Selenium;

namespace BDD_Framework.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private By username = By.Id("username");
        private By password = By.Id("password");
        private By loginBtn = By.XPath("//button[text()='Login']");
        private By successMsg = By.Id("success");

        public void Login(string user, string pass)
        {
            driver.FindElement(username).SendKeys(user);
            driver.FindElement(password).SendKeys(pass);
            driver.FindElement(loginBtn).Click();
        }

        public bool IsLoginSuccess()
        {
            return driver.FindElement(successMsg).Displayed;
        }
    }
}