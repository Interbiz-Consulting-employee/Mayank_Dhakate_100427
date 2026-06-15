using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers; // NuGet package: DotNetSeleniumExtras.WaitHelpers
using System;

namespace Selenium_remaining
{
    // Yahan 'class Program' hona zaruri hai
    class Program
    {
        static void Main(string[] args)
        {
            // Chrome Options (Optional: Pop-ups block karne ke liye)
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);

            try
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.Navigate().GoToUrl("https://www.amazon.in");
                ((WebElement)driver.FindElement(By.XPath(("//button[@type='submit' and normalize-space()='Continue shopping']")))).Click();

                // --- SCROLL ---
                // "Back to top" footer element
                IWebElement scrollToElement = driver.FindElement(By.XPath("//span[contains(text(),'Back to top')]"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);
                Console.WriteLine("1. Scrolled to footer.");

                // --- HOVER ---
                Actions actions = new Actions(driver);
                IWebElement hoverElement = driver.FindElement(By.XPath("//img[@alt=\"Today’s Deals\"]"));
                actions.MoveToElement(hoverElement).Perform();
               

                //// --- WINDOW HANDLING ---
                //string parentWindow = driver.CurrentWindowHandle;
                //IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
                //searchBox.SendKeys("iPhone 15" + Keys.Enter);

                //// Pehla product link click karein
                //IWebElement firstProduct = driver.FindElement(By.XPath("(//h2//a)[1]"));
                //firstProduct.Click();

                //foreach (string window in driver.WindowHandles)
                //{
                //    if (window != parentWindow)
                //    {
                //        driver.SwitchTo().Window(window);
                //        Console.WriteLine("3. Switched to New Tab: " + driver.Title);
                //        break;
                //    }
                //}

                //// --- ALERTS ---
                //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                //js.ExecuteScript("alert('Selenium Test Alert');");
                //System.Threading.Thread.Sleep(1000); // Alert dikhne ke liye chhota pause
                //IAlert alert = driver.SwitchTo().Alert();
                //Console.WriteLine("4. Alert Text: " + alert.Text);
                //alert.Accept();

                //// --- EXPLICIT WAIT ---
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
                //// Amazon pe Add to Cart button ki ID 'add-to-cart-button' hoti hai
                //IWebElement addToCartBtn = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add-to-cart-button")));
                //Console.WriteLine("5. Add to Cart button is visible.");

                //// --- FLUENT WAIT ---
                //DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
                //{
                //    Timeout = TimeSpan.FromSeconds(20),
                //    PollingInterval = TimeSpan.FromSeconds(2)
                //};
                //fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

                //IWebElement buyNowBtn = fluentWait.Until(drv => drv.FindElement(By.Id("buy-now-button")));
                //Console.WriteLine("6. Buy Now button found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Test Finished. Closing browser...");
                driver.Quit();
            }
        }
    }
}