public static class ConfigReader
{
    public static string GetBaseUrl(string testName)
    {
        if (testName == "VerifyLoginadmin")
            return "https://test.rovicare.com/";

        if (testName == "VerifyLogin")
            return "https://beta.rovicare.com/";

        return "https://test.rovicare.com/"; // default safe fallback
    }
}