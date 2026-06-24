using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System;
using System.IO;

namespace Project4.Reports
{
    public static class ExtentManager
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        private static ExtentSparkReporter sparkReporter;

        
        public static IWebDriver driver;

        public static void SetDriver(IWebDriver webDriver)
        {
            driver = webDriver;
        }

        public static void InitReport()
        {
            string reportFolder = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Reports"
            );

            if (!Directory.Exists(reportFolder))
            {
                Directory.CreateDirectory(reportFolder);
            }

            string reportPath = Path.Combine(
                reportFolder,
                "ExtentReport_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html"
            );

            sparkReporter = new ExtentSparkReporter(reportPath);

            extent = new ExtentReports();
            extent.AttachReporter(sparkReporter);

            extent.AddSystemInfo("Project", "Rovicare");
            extent.AddSystemInfo("Environment", "QA");
        }

        public static void CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        // SCREENSHOT METHOD
        public static string TakeScreenshot(string name)
        {
            try
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;

                Screenshot screenshot = ts.GetScreenshot();

                string folder = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Screenshots"
                );

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string path = Path.Combine(folder, name + "_" +
                    DateTime.Now.ToString("yyyyMMddHHmmss") + ".png");

                screenshot.SaveAsFile(path);

                return path;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Screenshot error: " + ex.Message);
                return null;
            }
        }

        // PASS with screenshot
        public static void LogPass(string message)
        {
            string path = TakeScreenshot("PASS");

            if (path != null)
                test.Pass(message).AddScreenCaptureFromPath(path);
            else
                test.Pass(message);
        }

        // FAIL with screenshot
        public static void LogFail(string message)
        {
            string path = TakeScreenshot("FAIL");

            if (path != null)
                test.Fail(message).AddScreenCaptureFromPath(path);
            else
                test.Fail(message);
        }

        // SKIP with screenshot
        public static void LogSkip(string message)
        {
            string path = TakeScreenshot("SKIP");

            if (path != null)
                test.Skip(message).AddScreenCaptureFromPath(path);
            else
                test.Skip(message);
        }

        public static void FlushReport()
        {
            extent.Flush();
        }
    }
}