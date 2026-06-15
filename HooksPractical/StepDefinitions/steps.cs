using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

[Binding]
public class Hooks
{
    private readonly DriverContext _context;

    // Extent variables
    private static ExtentReports _extent;
    private static ExtentTest _feature;
    private static ExtentTest _scenario;

    public Hooks(DriverContext context)
    {
        _context = context;
    }

    //  1. Runs once before everything
    [BeforeTestRun]
    public static void BeforeTestRun()
    {
        string reportDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports");
        Directory.CreateDirectory(reportDir);

        string reportPath = Path.Combine(reportDir, "ExtentReport.html");

        var sparkReporter = new ExtentSparkReporter(reportPath);

        _extent = new ExtentReports();
        _extent.AttachReporter(sparkReporter);

        TestContext.WriteLine("Report Path: " + reportPath);
    }

    //  2. Runs before each Feature
    [BeforeFeature]
    public static void BeforeFeature(FeatureContext context)
    {
        _feature = _extent.CreateTest(context.FeatureInfo.Title);

        TestContext.WriteLine(" FEATURE START: " + context.FeatureInfo.Title);
    }

    //  3. BEFORE EACH SCENARIO
    [BeforeScenario]
    public void BeforeScenario(ScenarioContext context)
    {
        _scenario = _feature.CreateNode(context.ScenarioInfo.Title);

        TestContext.WriteLine("Scenario Started: " + context.ScenarioInfo.Title);

        _context.Driver = new ChromeDriver();
        _context.Driver.Manage().Window.Maximize();
    }

    //  4. BEFORE EACH STEP
    [BeforeStep]
    public void BeforeStep(ScenarioContext context)
    {
        TestContext.WriteLine("Step Starting: " + context.StepContext.StepInfo.Text);
    }

    //  5. AFTER EACH STEP (EXTENT LOGGING)
    [AfterStep]
    public void AfterStep(ScenarioContext scenarioContext)
    {
        var stepName = scenarioContext.StepContext.StepInfo.Text;
        var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

        if (scenarioContext.TestError == null)
        {
            _scenario.Pass(stepType + " " + stepName);
        }
        else
        {
            _scenario.Fail(stepType + " " + stepName + " - " + scenarioContext.TestError.Message);

            // Screenshot on failure
            var screenshot = ((ITakesScreenshot)_context.Driver).GetScreenshot();

            string folder = Path.Combine(Directory.GetCurrentDirectory(), "Screenshots");
            Directory.CreateDirectory(folder);

            string fileName = "error_" + DateTime.Now.Ticks + ".png";
            string fullPath = Path.Combine(folder, fileName);

            screenshot.SaveAsFile(fullPath);

            _scenario.AddScreenCaptureFromPath(fullPath);

            TestContext.WriteLine("Screenshot saved: " + fullPath);
        }
    }

    //  6. AFTER SCENARIO
    [AfterScenario]
    public void AfterScenario(ScenarioContext context)
    {
        _context.Driver.Quit();
        TestContext.WriteLine(" Browser Closed");
    }

    //  7. AFTER FEATURE
    [AfterFeature]
    public static void AfterFeature()
    {
        TestContext.WriteLine(" FEATURE ENDED");
    }

    //  8. FINAL END ( REPORT GENERATE)
    [AfterTestRun]
    public static void AfterTestRun()
    {
        _extent.Flush(); //  VERY IMPORTANT

        TestContext.WriteLine(" TEST RUN COMPLETED");
    }

    //  TAG BASED HOOK
    [BeforeScenario("@smoke")]
    public void BeforeSmokeScenario()
    {
        TestContext.WriteLine(" SMOKE SCENARIO STARTED");

        // Optional: tag in report
        _scenario.AssignCategory("Smoke");
    }
}