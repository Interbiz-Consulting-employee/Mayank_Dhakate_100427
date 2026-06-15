using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeleniumPractice_4
{
    class Program
    {
        // We declare these at the class level so they can be accessed if you 
        // decide to move logic into separate methods later.
        static IWebDriver driver;
        static WebDriverWait wait;

        static void Main(string[] args)
        {
            // 1. INITIALIZATION
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");

            // Fix: Initialize the static driver variable
            driver = new ChromeDriver(options);

            // Fix: Initialize the static wait variable
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            try
            {
                // --- CONCEPT 1: SCROLL TO ELEMENT ---
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
                IWebElement footer = driver.FindElement(By.Id("page-footer"));

                // Fix: Correct Casting for JavaScript Execution
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", footer);
                Console.WriteLine("Step 1: Scrolled to footer.");

                // --- CONCEPT 2: ACTIONS (Hover) ---
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
                IWebElement avatar = driver.FindElement(By.ClassName("figure"));

                // Fix: Ensure Actions is initialized with the driver
                Actions actions = new Actions(driver);
                actions.MoveToElement(avatar).Perform();
                Console.WriteLine("Step 2: Hovered using Actions.");

                // --- CONCEPT 3: WINDOW HANDLER ---
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");
                string parentHandle = driver.CurrentWindowHandle;
                driver.FindElement(By.LinkText("Click Here")).Click();

                // Fix: Explicitly wait for the new window to appear before counting
                wait.Until(d => d.WindowHandles.Count > 1);

                foreach (string handle in driver.WindowHandles)
                {
                    if (handle != parentHandle)
                    {
                        driver.SwitchTo().Window(handle);
                        Console.WriteLine("Step 3: Switched to Window: " + driver.Title);
                        driver.Close(); // Close the new tab
                    }
                }
                driver.SwitchTo().Window(parentHandle); // Return to original
                Console.WriteLine("Step 3: Returned to Parent Window.");

                // --- CONCEPT 4: FRAMES ---
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");

                // Fix: Must switch focus into the frame to see the editor
                driver.SwitchTo().Frame("mce_0_ifr");
                IWebElement editor = driver.FindElement(By.Id("tinymce"));
                editor.Clear();
                editor.SendKeys("Hello from Selenium!");

                // Fix: Must switch back to main content to continue testing
                driver.SwitchTo().DefaultContent();
                Console.WriteLine("Step 4: Handled Frame and returned to default content.");

                // --- CONCEPT 5: ALERTS ---
                driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
                driver.FindElement(By.XPath("//button[text()='Click for JS Alert']")).Click();

                // Fix: Use Explicit Wait to handle alert pop-up timing
                IAlert alert = wait.Until(ExpectedConditions.AlertIsPresent());
                Console.WriteLine("Step 5: Alert Text: " + alert.Text);
                alert.Accept();

                // --- CONCEPT 6: FLUENT WAIT ---
                // Fix: Properly configure polling and ignored exceptions
                DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
                {
                    Timeout = TimeSpan.FromSeconds(5),
                    PollingInterval = TimeSpan.FromMilliseconds(500)
                };
                fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));

                fluentWait.Until(d => d.FindElement(By.Id("content")));
                Console.WriteLine("Step 6: Fluent Wait check passed.");

                Console.WriteLine("\nSUCCESS: All automation concepts executed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("CRITICAL ERROR: " + ex.Message);
            }
            finally
            {
                // Fix: Ensure the browser closes even if an error occurs
                driver.Quit();
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}