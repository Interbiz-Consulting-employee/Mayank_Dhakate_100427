//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI;
//using System;

//class AmazonAutomation
//{
//    static void Main(string[] args)
//    {
//        // 1. Launch Chrome
//        IWebDriver driver = new ChromeDriver();
//        driver.Manage().Window.Maximize();

//        // 2. Implicit Wait (Global)
//        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

//        // Navigate to Amazon
//        driver.Navigate().GoToUrl("https://www.amazon.in");

//        // 3. Scroll to an element
//        IWebElement scrollToElement = driver.FindElement(By.XPath("YOUR_XPATH_HERE"));
//        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", scrollToElement);

//        // 4. Actions (Mouse Hover / Click)
//        Actions actions = new Actions(driver);
//        IWebElement hoverElement = driver.FindElement(By.XPath("//img[contains(@class, '_Zmx1a_fluidLandscapeImage_2euAK')]"));
//        actions.MoveToElement(hoverElement).Perform();

//        // 5. Window Handling (Switch between windows)
//        string parentWindow = driver.CurrentWindowHandle;
//        IWebElement newTabLink = driver.FindElement(By.XPath("YOUR_XPATH_HERE"));
//        newTabLink.Click();

//        foreach (string window in driver.WindowHandles)
//        {
//            if (window != parentWindow)
//            {
//                driver.SwitchTo().Window(window);
//                break;
//            }
//        }

//        // 6. Frames Handling
//        driver.SwitchTo().Frame("FRAME_NAME_OR_ID"); // Use ID or Name of iframe
//        IWebElement frameElement = driver.FindElement(By.XPath("YOUR_XPATH_HERE"));
//        frameElement.Click();
//        driver.SwitchTo().DefaultContent(); // Back to main page

//        // 7. Alerts Handling
//        // Simulating an alert (for example purpose)
//        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
//        js.ExecuteScript("alert('Test Alert');");
//        IAlert alert = driver.SwitchTo().Alert();
//        Console.WriteLine("Alert Text: " + alert.Text);
//        alert.Accept(); // Accept the alert

//        // 8. Explicit Wait
//        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
//        IWebElement explicitWaitElement = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("YOUR_XPATH_HERE")));
//        explicitWaitElement.Click();

//        // 9. Fluent Wait
//        DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver)
//        {
//            Timeout = TimeSpan.FromSeconds(20),
//            PollingInterval = TimeSpan.FromSeconds(2)
//        };
//        fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
//        IWebElement fluentElement = fluentWait.Until(drv => drv.FindElement(By.XPath("YOUR_XPATH_HERE")));
//        fluentElement.Click();

//        // Close browser
//        driver.Quit();
//    }
//}