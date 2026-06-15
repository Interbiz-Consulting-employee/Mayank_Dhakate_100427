using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

[TestFixture]
public class InterviewAutomationSuite
{
    private IWebDriver driver;
    private ExtentReports extent;
    private ExtentTest test;
    private string reportPath;

    
    [OneTimeSetUp]
    public void StartReport()
    {
        
        Directory.CreateDirectory(@"D:\Study\Mayank_Dhakate_100427\ExtentReport\Reports");
        Directory.CreateDirectory(@"D:\Study\Mayank_Dhakate_100427\ExtentReport\Screenshots");

      
        reportPath = Path.Combine(
            @"D:\Study\Mayank_Dhakate_100427\ExtentReport\Reports",
            "InterviewReport.html"
        );

        var spark = new ExtentSparkReporter(reportPath);

        spark.Config.DocumentTitle = "Automation Report";
        spark.Config.ReportName = "Selenium NUnit Dashboard";
        //spark.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

        extent = new ExtentReports();
        extent.AttachReporter(spark);

        extent.AddSystemInfo("Tester", "Mayank");
        extent.AddSystemInfo("Framework", "Selenium + NUnit");
        extent.AddSystemInfo("Browser", "Chrome");
        extent.AddSystemInfo("Place", "Raipur");
        Console.WriteLine("Report Initialized");
    }

 
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }


    [Test]
    public void TC01_VerifyGoogleTitle()
    {
        test = extent.CreateTest("TC01_VerifyGoogleTitle");

        driver.Navigate().GoToUrl("https://www.google.com");

        Assert.That(driver.Title.Contains("Google"));
    }

   
    [Test]
    public void TC02_FailDemo()
    {
        test = extent.CreateTest("TC02_FailDemo");

        driver.Navigate().GoToUrl("https://www.google.com");

        Assert.That(driver.Title.Contains("WrongTitle"));
    }

    
    [Test]
    public void TC03_SearchBoxTest()
    {
        test = extent.CreateTest("TC03_SearchBoxTest");

        driver.Navigate().GoToUrl("https://www.google.com");

        IWebElement search = driver.FindElement(By.Name("q"));

        Assert.That(search.Displayed);
    }

    
    [Test]
    public void TC04_PracticeLogin_Valid()
    {
        test = extent.CreateTest("TC04_PracticeLogin_Valid");

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

        driver.FindElement(By.Id("username")).SendKeys("student");
        driver.FindElement(By.Id("password")).SendKeys("Password123");
        driver.FindElement(By.Id("submit")).Click();

        IWebElement message = driver.FindElement(By.ClassName("post-title"));

        Assert.That(message.Text.Contains("Logged In"));
    }


    [Test]
    public void TC05_PracticeLogin_Invalid()
    {
        test = extent.CreateTest("TC05_PracticeLogin_Invalid");

        driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");

        driver.FindElement(By.Id("username")).SendKeys("wrong");
        driver.FindElement(By.Id("password")).SendKeys("wrong");
        driver.FindElement(By.Id("submit")).Click();

        IWebElement error = driver.FindElement(By.Id("error"));

        Assert.That(error.Displayed);
    }
    [Test]
    public void TC06_SkipDemo()
    {
        test = extent.CreateTest("TC06_SkipDemo");

        driver.Navigate().GoToUrl("https://www.google.com");

        Assert.Ignore("Skipping test intentionally");
    }

    [TearDown]
    public void TearDown()
    {
        var status = TestContext.CurrentContext.Result.Outcome.Status;

        string screenshotPath = CaptureScreenshot();

        if (status == TestStatus.Passed)
        {
            test?.Pass("Test Passed")
                .AddScreenCaptureFromPath(screenshotPath);
        }
        else if (status == TestStatus.Failed)
        {
            test?.Fail("Test Failed")
                .AddScreenCaptureFromPath(screenshotPath);
        }
        else if (status == TestStatus.Skipped)
        {
            test?.Skip("Test Skipped")
                .AddScreenCaptureFromPath(screenshotPath);
        }

        driver.Quit();
        driver.Dispose();
    }

    
    public string CaptureScreenshot()
    {
        string screenshotDir = @"D:\Study\Mayank_Dhakate_100427\ExtentReport\Screenshots";

        string fileName = "SS_" + TestContext.CurrentContext.Test.Name + "_" + DateTime.Now.Ticks + ".png";

        string fullPath = Path.Combine(screenshotDir, fileName);

        Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
        screenshot.SaveAsFile(fullPath);

        return fullPath;
    }

    
    [OneTimeTearDown]
    public void EndReport()
    {
        extent.Flush();

        Console.WriteLine("Report Generated: " + reportPath);
    }
}