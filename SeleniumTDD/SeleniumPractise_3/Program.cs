using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;

namespace SeleniumPractice
{
    class Program
    {
        static IWebDriver driver;
        static WebDriverWait wait;

        static void Main(string[] args)
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            ////driver.Navigate().GoToUrl("https://www.amazon.sg/s?k=Iphone&ref=mr_direct_us_sg_sg");
            ////Thread.Sleep(1000);

            //////wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //////// ================================
            //////// 🔹 LOCATOR (Change only this)
            //////// ================================
            ////IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            ////// Scroll to middle of the page
            ////js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight / 2);");
            ////Thread.Sleep(3000);
            //////// ================================
            //////// 🔹 ACTIONS (Hover / Click / Drag)
            //////// ================================
            ////By elementLocator = By.XPath("/html/body/div[1]/header/div/div[5]/div[2]/div/div/ul/li[11]/div/a/span");

            ////// Wait until element visible
            ////wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ////// Hover action
            ////Actions actions = new Actions(driver);
            ////IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(elementLocator));

            ////if (element == null)
            ////{
            ////    Console.WriteLine("Element not found!");
            ////    return;
            ////}
            ////actions.MoveToElement(element).Perform();

            ////// Wait for 2 seconds
            ////Thread.Sleep(20000);
            ////driver.Quit();

            ////// ================================
            ////// 🔹 CLICK AFTER WAIT
            ////// ================================
            ////wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator)).Click();

            ////// ================================
            ////// 🔹 WINDOW HANDLING
            ////// ================================
            // 1. Open Amazon
            driver.Navigate().GoToUrl("https://www.amazon.com");
            string amazonWindow = driver.CurrentWindowHandle;

            // 2. Open Flipkart in new tab
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open('https://www.flipkart.com','_blank');");

            // 3. Open Google in new tab
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open('https://www.google.com','_blank');");

            Thread.Sleep(2000); // wait for tabs to load

            // Get all window handles
            var allWindows = driver.WindowHandles;

            Console.WriteLine("All open windows:");
            foreach (var window in allWindows)
            {
                driver.SwitchTo().Window(window);
                Console.WriteLine(driver.Title);
            }

            // Switch back to Amazon window
            driver.SwitchTo().Window(amazonWindow);
            Console.WriteLine("Switched back to Amazon window:");
            Console.WriteLine(driver.Title);

            // Pause before closing
            Thread.Sleep(3000);

            //driver.Quit();
            ////// ================================
            ////// 🔹 ALERT HANDLING
            ////// ================================
            ////try
            ////{
            ////    IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
            ////    Console.WriteLine(alert.Text);
            ////    alert.Accept(); // or alert.Dismiss();
            ////}
            ////catch (WebDriverTimeoutException)
            ////{
            ////    Console.WriteLine("No alert present");
            ////}

            ////// ================================
            ////// 🔹 WAITS
            ////// ================================

            ////// Implicit Wait
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            //// Explicit Wait (already used above)

            //// Fluent Wait
            //DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
            //{
            //    Timeout = TimeSpan.FromSeconds(15),
            //    PollingInterval = TimeSpan.FromSeconds(2)
            //};

            //fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //IWebElement fluentElement = fluentWait.Until(drv => drv.FindElement(elementLocator));

            ////// ================================
            ////// 🔹 CLEANUP
            ////// ================================
            //Console.WriteLine("Execution Completed");
            //driver.Quit();


            // Set up Chrome
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            // Initialize Driver
            IWebDriver driver = new ChromeDriver(options);

            // Explicit Wait - 10 second timeout
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                // 1. SCROLL TO ELEMENT
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
                IWebElement footer = driver.FindElement(By.Id("page-footer"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", footer);
                Console.WriteLine("Step 1: Scrolled to footer.");

                // 2. ACTIONS (Hover)
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
                IWebElement avatar = driver.FindElement(By.ClassName("figure"));
                new Actions(driver).MoveToElement(avatar).Perform();
                Console.WriteLine("Step 2: Hovered using Actions.");

                // 3. WINDOW HANDLER
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
                string parent = driver.CurrentWindowHandle;
                driver.FindElement(By.LinkText("Click Here")).Click();

                // Wait for window count to increase
                wait.Until(d => d.WindowHandles.Count > 1);
                foreach (string handle in driver.WindowHandles)
                {
                    if (handle != parent)
                    {
                        driver.SwitchTo().Window(handle);
                        Console.WriteLine("Step 3: New Window Title - " + driver.Title);
                        driver.Close();
                    }
                }
                driver.SwitchTo().Window(parent);

                // 4. FRAMES
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
                driver.SwitchTo().Frame("mce_0_ifr"); // Enter the frame
                driver.FindElement(By.Id("tinymce")).Clear();
                driver.FindElement(By.Id("tinymce")).SendKeys("Selenium 2026 Test Success!");
                driver.SwitchTo().DefaultContent(); // Exit the frame
                Console.WriteLine("Step 4: Frame handled.");

                // 5. ALERTS
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
                driver.FindElement(By.XPath("//button[text()='Click for JS Alert']")).Click();
                IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
                alert.Accept();
                Console.WriteLine("Step 5: Alert accepted.");

                // 6. FLUENT WAIT (Custom Polling)
                DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
                fluentWait.Timeout = TimeSpan.FromSeconds(5);
                fluentWait.PollingInterval = TimeSpan.FromMilliseconds(500);
                fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

                fluentWait.Until(d => d.FindElement(By.Id("content")));
                Console.WriteLine("Step 6: Fluent wait confirmed element exists.");

                Console.WriteLine("\n--- ALL TESTS PASSED SUCCESSFULLY ---");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
            finally
            {
                driver.Quit(); // Ensures the browser closes even if the test fails
            }

            // Keep console window open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}