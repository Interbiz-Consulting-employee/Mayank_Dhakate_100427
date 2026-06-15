internal class ExtentHtmlReporter
{
    private string v;

    public ExtentHtmlReporter(string v)
    {
        this.v = v;
    }

    public object Config { get; internal set; }
}