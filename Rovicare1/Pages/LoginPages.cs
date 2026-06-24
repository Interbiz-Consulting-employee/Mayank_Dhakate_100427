using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class LoginPage
{
    private readonly IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }


    // ---------------- LOCATORS ----------------

    private readonly By username = By.Id("signInName");
    private readonly By password = By.Id("password");
    private readonly By loginBtn = By.Id("next");


    private readonly By outgoing =
        By.XPath("//a[@title='Outgoing']//i");


    private readonly By multiSelectInput =
        By.XPath("//app-multi-select//input");


    private readonly By patient =
        By.XPath("//a[@title='Preferred Facility List']");


    private readonly By serviceInitiated =
        By.CssSelector("i.service-initiated-icon");


    private readonly By yesclick =
        By.XPath("//mat-radio-group[@formcontrolname='wasServiceInitiated']//label[normalize-space()='Yes']");


    private readonly By selectDate =
        By.XPath("//app-date-time-picker//input[@placeholder='Select Date']");


    private readonly By adminorgbutton =
        By.XPath("//a[normalize-space()='Organization List']");


    private readonly By name =
        By.XPath("//input[@placeholder='By Name']");


    private readonly By goButton =
        By.XPath("//button[normalize-space()='Go']");


    private readonly By editButton =
        By.XPath("//*[@id='AddHospitalTblid']/tbody/tr[2]/td/div[1]/div[5]/action/div/span[2]/a/button");


    //private readonly By featureCheckbox =
    //    By.XPath("//input[@name='feature4']/ancestor::mat-checkbox");


    private readonly By submitButton =
        By.XPath("//button[@name='create' and normalize-space()='Submit']");


    private readonly By decisionDialogButton =
        By.CssSelector("button.app-global-button.primary-button");


    private readonly By spinner =
        By.Id("spinner");

    private readonly By calendarButton =
    By.XPath("//*[@id='mat-mdc-dialog-0']/div/div/app-service-initiation/div/div[2]/form/div/div[2]/div/div[1]/app-date-time-picker/span/div/div/div/div/div/div/button[3]");
    private readonly By calendarDate =
    By.XPath("//*[@id='mat-mdc-dialog-0']/div/div/app-service-initiation/div/div[2]/form/div/div[2]/div/div[1]/app-date-time-picker/span/div/div/div/div/div/mat-calendar/div/mat-month-view/table/tbody/tr[5]/td[4]/button/span[1]");

    private readonly By dialogButton =
    By.XPath("//*[@id='mat-mdc-dialog-0']/div/div/app-service-initiation/div/div[3]/button[2]");
    private readonly By featureCheckbox =
    By.Id("mat-mdc-checkbox-11-input");
    private readonly By scrollContainer =
    By.XPath("//*[@id='FeaturesInfo']/mat-card/mat-card-content/div/div[1]/div/div");
    private readonly By addOrgButton =
    By.XPath("//*[@id='addOrganizationForm']/div/div[2]/div[2]/button");
    // ---------------- WAIT ----------------


    private void WaitForSpinner()
    {
        WebDriverWait wait =
            new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        wait.Until(d =>
        {
            try
            {
                return !d.FindElement(spinner).Displayed;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
        });
    }



    // ---------------- LOGIN ----------------


    public void Login(string user, string pass)
    {
        WaitHelper.WaitForElement(driver, username, 50)
            .SendKeys(user);

        WaitHelper.WaitForElement(driver, password, 50)
            .SendKeys(pass);


        WaitHelper.WaitForElement(driver, loginBtn, 50)
            .Click();
    }



    public void ClickOutgoing()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, outgoing, 30)
            .Click();
    }



    public void SelectConfirmedFromMultiSelect()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, multiSelectInput, 30)
            .Click();


        var options =
            driver.FindElements(
                By.XPath("//*[contains(text(),'Confirmed')]"));

        Console.WriteLine(
            $"Found {options.Count} options");
    }



    public void ClickPatient()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, patient, 30)
            .Click();
    }



    public void Clickservice()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, serviceInitiated, 30)
            .Click();
    }



    public void ClickYesServiceInitiated()
    {
        var yes = driver.FindElement(yesclick);

        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", yes);
    }



    // ---------------- DATE ----------------


    public void ClickSelectdate()
    {
        WaitForSpinner();

        var date =
            WaitHelper.WaitForElement(driver, selectDate, 30);


        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", date);
    }




    // ---------------- ORGANIZATION ----------------


    public void Clickadminorg()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, adminorgbutton, 30)
            .Click();
    }


    public void SearchOrg()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, name, 30)
            .SendKeys("Arizona State Hospital");
    }



    public void ClickGoButton()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, goButton, 30)
            .Click();
    }



    public void ClickEditButton()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, editButton, 30)
            .Click();
    }



    public void ScrollToBottom()
    {
        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "window.scrollTo(0, document.body.scrollHeight);");

        Thread.Sleep(1000);
    }



    // ---------------- CHECKBOX ----------------


    public void ScrollAndToggleCheckbox()
    {
        // wait for page settle
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        // STEP 1: scroll container
        var container = wait.Until(d => d.FindElement(scrollContainer));

        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].scrollTop = arguments[0].scrollHeight;",
            container);

        Thread.Sleep(1000);

        // STEP 2: scroll checkbox into view
        var checkbox = wait.Until(d => d.FindElement(featureCheckbox));

        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].scrollIntoView(true);",
            checkbox);

        Thread.Sleep(500);

        // STEP 3: click (JS click safest for Angular)
        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", checkbox);
    }



    // ---------------- SUBMIT ----------------


    public void ClickSubmit()
    {
        WaitForSpinner();


        var submit =
            WaitHelper.WaitForElement(driver, submitButton, 30);


        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", submit);
    }



    public void ClickDecisionDialogButton()
    {
        WaitForSpinner();

        WaitHelper.WaitForElement(driver, decisionDialogButton, 30)
            .Click();
    }
    public void ClickCalendartime()
    {
        WaitForSpinner();

        var button =
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))
            .Until(driver =>
            {
                var element = driver.FindElement(calendarButton);

                return (element.Displayed && element.Enabled)
                    ? element
                    : null;
            });


        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", button);
    }
    public void ClickCalendarDate()
    {
        WaitForSpinner();

        var date =
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))
            .Until(driver =>
            {
                var element = driver.FindElement(calendarDate);

                return (element.Displayed && element.Enabled)
                    ? element
                    : null;
            });


        ((IJavaScriptExecutor)driver)
            .ExecuteScript(
            "arguments[0].click();", date);
    }
    public void ClickDialogButton()
    {
        var button =
            new WebDriverWait(driver, TimeSpan.FromSeconds(30))
            .Until(driver =>
            {
                var element = driver.FindElement(dialogButton);

                return (element.Displayed && element.Enabled)
                    ? element
                    : null;
            });


        button.Click();
    }
    public void ClickAddOrganizationButton()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));

        var button = wait.Until(d =>
        {
            var el = d.FindElement(addOrgButton);
            return (el.Displayed && el.Enabled) ? el : null;
        });

        ((IJavaScriptExecutor)driver)
            .ExecuteScript("arguments[0].scrollIntoView(true);", button);

        Thread.Sleep(500);

        button.Click();
    }
}