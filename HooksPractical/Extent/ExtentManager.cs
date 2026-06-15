using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

public class ExtentManager
{
    private static ExtentReports _extent;

    public static ExtentReports GetInstance()
    {
        if (_extent == null)
        {
            var htmlReporter = new ExtentHtmlReporter(@"Reports\ExtentReport.html");
            _extent = new ExtentReports();
            _extent.AttachReporter((IObserver<AventStack.ExtentReports.Listener.Entity.ReportEntity>)htmlReporter);
        }
        return _extent;
    }
}