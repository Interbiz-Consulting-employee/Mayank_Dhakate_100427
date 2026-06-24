using NUnit.Framework;

namespace AutomationFramework.Tests
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        [Test, Order(1)]
        public void VerifyLoginadmin()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.Login(
                "admin@rovicare.com",
                "SupeAdmin@132"
            );

            loginPage.Clickadminorg();
            loginPage.SearchOrg();
            loginPage.ClickGoButton();
            loginPage.ClickEditButton();
            loginPage.ScrollToBottom();
            loginPage.ScrollAndToggleCheckbox();
            loginPage.ClickAddOrganizationButton();
            loginPage.ClickDecisionDialogButton();
            Thread.Sleep(15000);
        }

        [Test, Order(2)]
        public void VerifyLogin()
        {
            LoginPage loginPage = new LoginPage(driver);

            loginPage.Login(
                "shivanshinterbiz@yopmail.com",
                "Beta@123"
            );

            loginPage.ClickOutgoing();
            loginPage.SelectConfirmedFromMultiSelect();
            loginPage.ClickPatient();
            loginPage.Clickservice();
            loginPage.ClickYesServiceInitiated();
            loginPage.ClickSelectdate();
            loginPage.ClickCalendarDate();
            loginPage.ClickCalendartime();
            loginPage.ClickDialogButton();

            Thread.Sleep(15000);
        }
    }
}