using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace SeleniumInterviewPrep
{
    class Program
    {
        static void Main(string[] args)
        {
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