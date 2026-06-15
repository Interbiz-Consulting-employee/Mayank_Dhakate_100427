using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Project4.Utilities;
public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // ---------------- LOCATORS ----------------

    private By username =
        By.XPath("//input[contains(@id,'signInName')]");

    private By password =
        By.Id("password");

    private By loginBtn =
        By.Id("next");

    private By organizationBtn =
        By.XPath("//button[normalize-space()='Organization']");

    private By organizationTypeDropdown =
        By.XPath("//mat-select[@name='organizationType']");

    private By healthcareProviderOption =
        By.XPath("//mat-option//span[normalize-space()='HealthCareProvider']");

    private By organizationNameTextBox =
        By.XPath("//mat-label[normalize-space()='Organization Name']/ancestor::mat-form-field//input");

    private By organizationLegalNameTextBox =
        By.XPath("//mat-label[normalize-space()='Organization Legal Name']/ancestor::mat-form-field//input");

    private By cityTextBox =
        By.XPath("//input[@name='city']");

    private By addressLine1TextBox =
        By.XPath("//mat-label[normalize-space()='Address Line 1']/ancestor::mat-form-field//input");

    private By zipcodeTextBox =
        By.XPath("//mat-label[normalize-space()='Zipcode']/ancestor::mat-form-field//input");

    private By settingsBtn =
        By.XPath("//a[@title='Settings']");
    private By dmeHealthCareProviderOption =
     By.XPath("//*[@id=\"mat-select-value-23\"]");
    private By secondDropdown =
    By.XPath("//*[@id='mat-select-value-15']/span");
    private By firstName =
    By.XPath("//*[@id='mat-input-17']");

    private By lastName =
        By.XPath("//*[@id='mat-input-19']");

    private By phoneNumber =
        By.XPath("//*[@id='mat-input-21']");

    private By email =
        By.XPath("//*[@id='mat-input-20']");
    private By submitButton =
    By.XPath("//button[@type='submit' and @name='create' and normalize-space()='SUBMIT']");
    private By stateDropdown =
    By.XPath("//*[@id='mat-select-value-25']/span");
    private By NPI =
    By.XPath("//*[@id='mat-input-16']");
    private By decisionDialogButton =
    By.XPath("//*[@id='decisionDialog']/mat-dialog-actions/div/div[2]/button");
    // ---------------- LOGIN FLOW ----------------

    public void Login(string user, string pass)
    {
        WaitHelper.WaitForElement(driver, username, 20).SendKeys(user);
        WaitHelper.WaitForElement(driver, password, 20).SendKeys(pass);
        WaitHelper.WaitForElement(driver, loginBtn, 20).Click();

        WaitHelper.WaitForElement(driver, settingsBtn, 30).Click();
        Thread.Sleep(2000);

        WaitHelper.WaitForElement(driver, organizationBtn, 20).Click();
        Thread.Sleep(2000);

        SelectOrganizationType();


    }

    // ---------------- ORGANIZATION FLOW ----------------

    public void SelectOrganizationType()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));


        // ---------------- SUBSCRIPTION DROPDOWN ----------------
        IWebElement subscription = wait.Until(d =>
        {
            var element = d.FindElement(dmeHealthCareProviderOption);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        subscription.Click();
        Thread.Sleep(1000);

        IWebElement dmeOption = wait.Until(d =>
        {
            var element = d.FindElement(
                By.XPath("//mat-option//span[normalize-space()='DMEHealthCareProvider']")
            );

            return (element.Displayed && element.Enabled) ? element : null;
        });

        dmeOption.Click();
        Thread.Sleep(2000);

        // ---------------- DROPDOWN (ORGANIZATION TYPE) ----------------
        IWebElement dropdown = wait.Until(d =>
        {
            var element = d.FindElement(
                By.XPath("//mat-select[@name='organizationType']//span[contains(@class,'mat-mdc-select-placeholder')]")
            );
            return (element.Displayed && element.Enabled) ? element : null;
        });

        dropdown.Click();
        Thread.Sleep(1000);

        IWebElement option = wait.Until(d =>
        {
            var element = d.FindElement(healthcareProviderOption);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        option.Click();
        Thread.Sleep(2000);

        // ---------------- ORGANIZATION NAME ----------------
        IWebElement orgInput = wait.Until(d =>
        {
            var element = d.FindElement(organizationNameTextBox);
            return (element.Displayed && element.Enabled) ? element : null;
        });
        string orgName = TestDataGenerator.GetUniqueOrganizationName();

        orgInput.Clear();
        orgInput.SendKeys(orgName);

        Console.WriteLine("Organization Name: " + orgName);

        Thread.Sleep(2000);

        // ---------------- ORGANIZATION LEGAL NAME ----------------
        IWebElement orgLegalInput = wait.Until(d =>
        {
            var element = d.FindElement(organizationLegalNameTextBox);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        orgLegalInput.Clear();
        orgLegalInput.SendKeys("organisation test 1234");

        Thread.Sleep(2000);

        // ---------------- CITY ----------------
        IWebElement cityInput = wait.Until(d =>
        {
            var element = d.FindElement(cityTextBox);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        cityInput.Clear();
        cityInput.SendKeys("boston");

        Thread.Sleep(2000);

        // ---------------- ADDRESS LINE 1 ----------------
        IWebElement addressInput = wait.Until(d =>
        {
            var element = d.FindElement(addressLine1TextBox);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        addressInput.Clear();
        addressInput.SendKeys("nne");

        Thread.Sleep(2000);

        // ---------------- ZIPCODE ----------------
        IWebElement zipInput = wait.Until(d =>
        {
            var element = d.FindElement(zipcodeTextBox);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        zipInput.Clear();
        zipInput.SendKeys("99504");

        Thread.Sleep(2000);
        //------------------State-------------------------------
        IWebElement stateDropdownElement = wait.Until(d =>
        {
            var element = d.FindElement(secondDropdown);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        stateDropdownElement.Click();
        Thread.Sleep(1000);

        // ---------------- SELECT 2ND OPTION ----------------
        IWebElement secondStateOption = wait.Until(d =>
        {
            var options = d.FindElements(By.XPath("//mat-option"));

            if (options.Count > 1 &&
                options[1].Displayed &&
                options[1].Enabled)
            {
                return options[1]; // 2nd option
            }

            return null;
        });

        secondStateOption.Click();
        Thread.Sleep(2000);
        // ---------------- FIRST NAME ----------------
        IWebElement firstNameInput = wait.Until(d =>
        {
            var element = d.FindElement(firstName);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        firstNameInput.Clear();
        firstNameInput.SendKeys("Jhon");

        Thread.Sleep(1000);

        // ---------------- LAST NAME ----------------
        IWebElement lastNameInput = wait.Until(d =>
        {
            var element = d.FindElement(lastName);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        lastNameInput.Clear();
        lastNameInput.SendKeys("doe");

        Thread.Sleep(1000);

        // ---------------- PHONE NUMBER ----------------
        IWebElement phoneInput = wait.Until(d =>
        {
            var element = d.FindElement(phoneNumber);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        phoneInput.Clear();
        phoneInput.SendKeys("7587123896");

        Thread.Sleep(1000);

        // ---------------- EMAIL ----------------
        IWebElement emailInput = wait.Until(d =>
        {
            var element = d.FindElement(email);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        emailInput.Clear();
        emailInput.SendKeys("abc@yopmail.com");

        Thread.Sleep(2000);
        //-------------------------------NPI---------------------
        IWebElement mobileInput = wait.Until(d =>
        {
            var element = d.FindElement(NPI);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        mobileInput.Clear();
        mobileInput.SendKeys("1234567896");

        // ---------------- SUBMIT ----------------
        IWebElement submitBtn = wait.Until(d =>
        {
            var element = d.FindElement(submitButton);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", submitBtn);
        Thread.Sleep(500);

        submitBtn.Click();
        Thread.Sleep(2000);
        //-------------------------------
        IWebElement dialogBtn = wait.Until(d =>
        {
            var element = d.FindElement(decisionDialogButton);
            return (element.Displayed && element.Enabled) ? element : null;
        });

        ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", dialogBtn);
        Thread.Sleep(500);

        dialogBtn.Click();
        Thread.Sleep(2000);
    }
   

}