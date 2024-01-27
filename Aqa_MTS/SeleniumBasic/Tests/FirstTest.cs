using NUnitTest.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    /*
    private IWebDriver webDriver;

    [SetUp]
    public void FactoryDriverTest()
    {
        webDriver = new Browser().Driver;
    }
    */
    
    [Test]
    public void ValidateIKTCalculationTest()
    {
        Driver.Navigate().GoToUrl("https://clinic-cvetkov.ru/company/kalkulyator-imt/");
        IWebElement height = Driver.FindElement(By.Name("height"));
        IWebElement weight = Driver.FindElement(By.Name("weight"));
        IWebElement button = Driver.FindElement(By.Id("calc-mass-c"));

        height.SendKeys("183");
        weight.SendKeys("58");
        button.Click();

        Thread.Sleep(2000);
        IWebElement result = Driver.FindElement(By.Id("imt-result"));
        Assert.That(result.Text, Is.EqualTo("17.3 - Недостаточная (дефицит) масса тела"));
    }
    
    /*
    [TearDown]
    public void TearDown()
    {
        webDriver.Quit();
    }
    */
    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(1);
        
        IWebElement selectWebElement = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectSex = new SelectElement(selectWebElement);
        
        selectSex.SelectByIndex(1);
        Thread.Sleep(2000);
        
        selectSex.SelectByValue("mm");
        Thread.Sleep(2000);
        
        selectSex.SelectByText("мг/дл");
        Thread.Sleep(2000);
    }
}