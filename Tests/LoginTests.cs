using NUnit.Framework;

[TestFixture]
public class LoginTests : BaseTest
{
    [Test]
    public void LoginTest()
    {
        LoginPage login = new LoginPage(driver);

        login.Login(
            "testsupport@yopmail.com",
            "Test@123");

        Console.WriteLine("Login Successful");


        Console.WriteLine("Current URL : " + driver.Url);
    }
}