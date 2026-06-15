using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using System;

[Binding]
public class ImportSteps
{
    private IWebDriver driver;

    [Given("I open the import page")]
    public void GivenIOpenTheImportPage()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();

        driver.Navigate().GoToUrl("webhook.site");
    }

    [When("I upload JSON file from desktop")]
    public void WhenIUploadJsonFileFromDesktop()
    {
        // 👇 Change username to your PC username
        string filePath = @"C:\Users\PC\Desktop\json1.json";

        var upload = driver.FindElement(By.Id("fileUpload"));
        upload.SendKeys(filePath);

        driver.FindElement(By.Id("submitBtn")).Click();
    }

    [Then("import should be successful")]
    public void ThenImportShouldBeSuccessful()
    {
        string message = driver.FindElement(By.Id("successMessage")).Text;

        if (!message.Contains("Success"))
        {
            throw new Exception("Import failed");
        }

        driver.Quit();
    }
}