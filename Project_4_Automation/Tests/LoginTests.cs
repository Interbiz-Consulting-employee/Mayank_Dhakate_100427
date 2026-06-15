using NUnit.Framework;
using Project4.Reports;

[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    public void LoginTest()
    {
        LoginPage login = new LoginPage(driver);

        login.Login(
            "AugustSupportAdmin@yopmail.com",
            "Test@123");

        Console.WriteLine("Login Successful");


        Console.WriteLine("Current URL : " + driver.Url);
        ExtentManager.CreateTest("Login Test");
        ExtentManager.LogPass("Login successful");
    }

}