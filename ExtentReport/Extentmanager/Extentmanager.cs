using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

public sealed class ExtentManager
{
    private static ExtentReports extent;
    private static object Configuration;
    private static readonly object lockObj = new object();

    public static ExtentReports GetInstance()
    {
        if (extent == null)
        {
            lock (lockObj)
            {
                if (extent == null)
                {
                    string reportPath = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "Reports",
                        "ExtentReport.html"
                    );

                    var spark = new ExtentSparkReporter(reportPath);

                    spark.Config.DocumentTitle = "Automation Report";
                    spark.Config.ReportName = "Selenium Execution Report";

                    //spark.Config.Theme =
                    //    Configuration.Theme.Dark;

                    extent = new ExtentReports();
                    extent.AttachReporter(spark);

                    // Optional System Info
                    extent.AddSystemInfo("Tester", "Mayank");
                    extent.AddSystemInfo("Framework", "Selenium + NUnit");
                    extent.AddSystemInfo("Environment", "QA");
                }
            }
        }

        return extent;
    }
}