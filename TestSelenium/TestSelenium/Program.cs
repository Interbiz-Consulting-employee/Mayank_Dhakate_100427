using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
namespace TestSelenium
{
    class SeleniumExample
    {
        static void Main(string[] args)
        {
            // 1. Setup ChromeDriver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            try
            {
                // 2. Navigate to demo site
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/");

                // ------------------------------
                // 3. Static Element
                // ------------------------------
                IWebElement staticElement = driver.FindElement(By.XPath("//a[contains(text(),'Input Forms')]"));
                staticElement.Click();

                // ------------------------------
                // 4. Dynamic Element (example: waits until visible)
                // ------------------------------
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement dynamicElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Simple Form Demo")));
                dynamicElement.Click();

                // ------------------------------
                // 5. Dropdown
                // ------------------------------
                IWebElement dropdownElement = driver.FindElement(By.Id("select-demo"));
                SelectElement select = new SelectElement(dropdownElement);
                select.SelectByText("Sunday"); // select option by text

                // ------------------------------
                // 6. Calendar (example: choose a date)
                // ------------------------------
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/bootstrap-date-picker-demo.html");
                IWebElement dateInput = driver.FindElement(By.XPath("//input[@placeholder='dd/mm/yyyy']"));
                dateInput.Click();
                IWebElement dateToSelect = driver.FindElement(By.XPath("//td[@class='day' and text()='15']"));
                dateToSelect.Click();

                // ------------------------------
                // 7. Mouse Hover
                // ------------------------------
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/jquery-dropdown-search-demo.html");
                IWebElement hoverMenu = driver.FindElement(By.XPath("//button[text()='Multiple Select']"));
                Actions actions = new Actions(driver);
                actions.MoveToElement(hoverMenu).Perform();
                Thread.Sleep(1000); // short pause to visualize hover

                // ------------------------------
                // 8. Scroll to Element
                // ------------------------------
                IWebElement scrollElement = driver.FindElement(By.XPath("//h3[contains(text(),'JQuery Select dropdown')]"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollElement);

                // ------------------------------
                // 9. Actions (Double Click & Right Click)
                // ------------------------------
                driver.Navigate().GoToUrl("https://demoqa.com/buttons");
                IWebElement doubleClickBtn = driver.FindElement(By.Id("doubleClickBtn"));
                IWebElement rightClickBtn = driver.FindElement(By.Id("rightClickBtn"));

                actions.DoubleClick(doubleClickBtn).Perform();
                actions.ContextClick(rightClickBtn).Perform();

                // ------------------------------
                // 10. Window Handling
                // ------------------------------
                driver.Navigate().GoToUrl("https://www.seleniumeasy.com/test/window-popup-modal-demo.html");
                string mainWindow = driver.CurrentWindowHandle;
                IWebElement popupButton = driver.FindElement(By.XPath("//a[contains(text(),'Follow On Twitter')]"));
                popupButton.Click();

                Thread.Sleep(2000); // wait for new window
                foreach (string handle in driver.WindowHandles)
                {
                    if (handle != mainWindow)
                    {
                        driver.SwitchTo().Window(handle);
                        Console.WriteLine("New Window Title: " + driver.Title);
                        driver.Close(); // close new window
                    }
                }
                driver.SwitchTo().Window(mainWindow);

                Console.WriteLine("All actions completed successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Thread.Sleep(3000);
                driver.Quit();
            }
        }
    }
}
