using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
namespace AmazonLogin
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.tutorialspoint.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement Login = driver.FindElement(By.XPath("//a[contains(@class,'tp-login-btn')]"));
            Login.Click();
            Thread.Sleep(2000);
            //IWebElement SignUp = driver.FindElement(By.XPath("//b[text()=' Sign Up']"));
            //SignUp.Click();
            //Thread.Sleep(2000);
            //IWebElement name1 = driver.FindElement(By.XPath("//input[@name='txtFullName']"));
            //name1.SendKeys("Mayank");
            //IWebElement email1 = driver.FindElement(By.XPath("//input[@name='txtEmailId']"));
            //email1.SendKeys("mayankdhakate93@gmail.com");
            //IWebElement signupbutton=driver.FindElement(By.Id("submitSingup"));
            //signupbutton.Click();
            //Thread.Sleep(2000);
            IWebElement LoginAdd = driver.FindElement(By.XPath("//input[@name='txtLoginEmailId']"));
            LoginAdd.SendKeys("mayank.dhakate@gmail.com");
            IWebElement LogPass = driver.FindElement(By.XPath("//input[@name='txtLoginPassword']"));
            LogPass.SendKeys("Mayank@09");
            IWebElement SubmitLogin = driver.FindElement(By.Id("submitLogin"));
            SubmitLogin.Click();
            Thread.Sleep(10000);
            IWebElement Cert = driver.FindElement(By.XPath("//*[text()=' Certifications ']"));
            Cert.Click();
            Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement completedCert = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='completed-certification.php']")));
            completedCert.Click();
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement userLogout = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[contains(@onclick,'userLogout')]")));
            userLogout.Click();
            Thread.Sleep(2000);
            driver.Quit();


        }
    }
}
