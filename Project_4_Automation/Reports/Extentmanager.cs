using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace Project4.Reports
{
    public static class ExtentManager
    {
        public static ExtentReports extent;
        public static ExtentTest test;
        private static ExtentSparkReporter sparkReporter;

        public static void InitReport()
        {
            try
            {
                
                string reportFolder = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "Reports"
                );

                // Create folder if not exists
                if (!Directory.Exists(reportFolder))
                {
                    Directory.CreateDirectory(reportFolder);
                }

                // Unique report name
                string reportPath = Path.Combine(
                    reportFolder,
                    "ExtentReport_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".html"
                );

                Console.WriteLine("Report Path: " + reportPath);

                // Initialize Spark Reporter (NEW VERSION)
                sparkReporter = new ExtentSparkReporter(reportPath);

                extent = new ExtentReports();
                extent.AttachReporter(sparkReporter);

                // System Info
                extent.AddSystemInfo("Project", "Project4");
                extent.AddSystemInfo("Environment", "QA");
                extent.AddSystemInfo("OS", Environment.OSVersion.ToString());

                Console.WriteLine("Extent Report Initialized Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("InitReport Error: " + ex.Message);
                throw;
            }
        }

        // Create Test
        public static void CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        // PASS
        public static void LogPass(string message)
        {
            test.Pass( message);
        }

        // FAIL
        public static void LogFail(string message)
        {
            test.Fail(  message);
        }

        // SKIP
        public static void LogSkip(string message)
        {
            test.Skip(message);
        }

        // Flush Report (IMPORTANT)
        public static void FlushReport()
        {
            extent.Flush();
            Console.WriteLine("Report Generated Successfully");
        }
    }
}