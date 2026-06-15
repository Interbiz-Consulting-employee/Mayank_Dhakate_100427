using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestAutomation1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();

                var login = new LoginModule(driver);

                Console.WriteLine("Navigating to login page...");
                login.GoToLoginPage();

                Console.WriteLine("Entering email...");
                login.EnterEmail("your-email@example.com"); // Replace with your email

                Console.WriteLine("Entering password...");
                login.EnterPassword("your-password"); // Replace with your password

                Console.WriteLine("Login completed successfully!");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Test failed: " + ex.Message);

                if (driver != null)
                {
                    
                    Console.WriteLine("Screenshot saved as Error.png");
                }
            }
            finally
            {
                driver?.Quit();
                Console.WriteLine("Browser closed. Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
