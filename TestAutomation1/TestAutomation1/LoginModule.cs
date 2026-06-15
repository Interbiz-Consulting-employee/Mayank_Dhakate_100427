using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestAutomation1
{
    public class LoginModule
    {
        private IWebDriver driver;
        private WebDriverWait wait;
        

        // Constructor to initialize driver and wait
        public LoginModule(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Module method: Navigate to Amazon login page
        public void GoToLoginPage()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com/");
            driver.FindElement(By.Id("nav-link-accountList")).Click();
        }

        // Module method: Enter email/phone
        public void EnterEmail(string email)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ap_email")));
            driver.FindElement(By.Id("ap_email")).Clear();
            driver.FindElement(By.Id("ap_email")).SendKeys(email);
            driver.FindElement(By.Id("continue")).Click();
        }

        // Module method: Enter password and submit
        public void EnterPassword(string password)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ap_password")));
            driver.FindElement(By.Id("ap_password")).Clear();
            driver.FindElement(By.Id("ap_password")).SendKeys(password);
            driver.FindElement(By.Id("signInSubmit")).Click();
        }
    }
}
