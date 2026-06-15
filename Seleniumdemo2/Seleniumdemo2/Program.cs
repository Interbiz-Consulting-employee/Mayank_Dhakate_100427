using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Seleniumdemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/demo-site/draganddrop/#google_vignette");
            driver.Manage().Window.Maximize();
            driver.SwitchTo().Frame(driver.FindElement(By.ClassName("demo-frame")));
            IWebElement source = driver.FindElement(By.XPath("//img[@alt='The peaks of High Tatras']"));
            IWebElement target = driver.FindElement(By.Id("trash"));
            Actions action = new Actions(driver);
            action.ContextClick(source).Perform();
            //action.DragAndDrop(source, target);
            Thread.Sleep(2000);

            //       WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //       // Wait until "Explore more" is clickable and click
            //       IWebElement exploreMore = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[text()='Explore more']")));
            //       exploreMore.Click();

            //       // Wait until the "Dropdown" section is clickable and click
            //       IWebElement dropdownSection = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Dropdown')]")));
            //       dropdownSection.Click();

            //       // Optional: keep browser open for 5 seconds to see the result
            //       System.Threading.Thread.Sleep(5000);
            //       IWebElement counrtycode = driver.FindElement(By.Id("country_code"));
            //       SelectElement select =new SelectElement(counrtycode);
            //       select.SelectByValue("+01");
            //       IWebElement Number = driver.FindElement(By.XPath("//input[contains(@id,'phone')]"));
            //       Number.SendKeys("7587321893");
            //       IWebElement male = driver.FindElement(By.XPath("//input[contains(@id,'male')]"));
            //       male.Click();
            //       IWebElement counrty = driver.FindElement(By.Id("select3"));
            //       SelectElement select1 =new SelectElement(counrty);
            //       select1.SelectByIndex(4);
            //       Thread.Sleep(2000);
            //       IWebElement date = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Date & Time Picker')]")));
            //       date.Click();
            //       System.Threading.Thread.Sleep(5000);
            //       IWebElement datepicker = driver.FindElement(By.XPath("//a[contains(@href, '/ui/datePick')]"));
            //       datepicker.Click();
            //       Thread.Sleep(2000);
            //       IWebElement dateInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@placeholder='Select A Date']")));
            //       dateInput.Click();
            //       WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            //       // Wait until the day is clickable
            //       IWebElement day17 = wait1.Until(ExpectedConditions.ElementToBeClickable(
            //           By.XPath("//div[contains(@class,'react-datepicker__day') and text()='17']")));

            //       // Click the date
            //       day17.Click();
            //       Thread.Sleep(2000);

            //       IWebElement Mousehover1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Mouse Actions')]")));
            //       Mousehover1.Click();
            //       IWebElement Mousehover2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Mouse Hover')]")));
            //       Mousehover2.Click();
            //       WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //       IWebElement imgElement = wait3.Until(ExpectedConditions.ElementIsVisible(
            //           By.XPath("//img[contains(@src,'message-hint')]")
            //       ));
            //       Actions act = new Actions(driver);
            //       act.MoveToElement(imgElement).Perform();
            //       Thread.Sleep(5000);

            //       //IWebElement scroll1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Scroll')]")));
            //       //scroll1.Click();
            //       //IWebElement scroll2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//section/a[text()='Open In New Tab']")));
            //       //scroll2.Click();
            //       //Thread.Sleep(2000);

            //       IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //       //js.ExecuteScript("window.scrollBy(0, 500);");
            //       //Thread.Sleep(2000);


            //       IWebElement Mousehover3 = wait.Until(
            //    ExpectedConditions.ElementToBeClickable(By.XPath("//section[contains(text(),'Mouse Actions')]"))
            //);
            //       Mousehover3.Click();

            //       IWebElement element = wait.Until(
            //           ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='/ui/dragDrop/dragToCorrect?sublist=2']"))
            //       );
            //       element.Click();

            //       IWebElement source = wait.Until(
            //           ExpectedConditions.ElementIsVisible(By.XPath("//div[normalize-space()='Mobile Charger']"))
            //       );

            //       IWebElement target = wait.Until(
            //           ExpectedConditions.ElementIsVisible(By.XPath("//div[normalize-space()='Mobile Accessories']"))
            //       );

            //       // Scroll
            //       ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", source);

            //       Actions action = new Actions(driver);

            //       action.ClickAndHold(source)
            //             .MoveToElement(target)
            //             .Release()
            //             .Perform();
            //       action.DragAndDrop(source, target).Perform();

            //       Thread.Sleep(9000);
            //       driver.Quit();
        }
    }
}