using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
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
    
    [Test]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Thread.Sleep(3000);
        Driver.SwitchTo().Frame(1);
        
        IWebElement age = Driver.FindElement(By.Name("age"));
        age.SendKeys("30");
        
        IWebElement selectWebElement1 = Driver.FindElement(By.Id("sex"));
        SelectElement selectSex = new SelectElement(selectWebElement1);
        selectSex.SelectByValue("F");
        Thread.Sleep(2000);
        
        IWebElement creatinin = Driver.FindElement(By.Name("cr"));
        creatinin.SendKeys("34");
        
        IWebElement selectWebElement2 = Driver.FindElement(By.Id("cr-size"));
        SelectElement selectCrSize = new SelectElement(selectWebElement2);
        selectCrSize.SelectByValue("mm");
        Thread.Sleep(2000);
        //selectSex.SelectByIndex(1);
        //Thread.Sleep(2000);
        //selectSex.SelectByText("мг/дл");
        //Thread.Sleep(2000);height
        
        IWebElement selectWebElement3 = Driver.FindElement(By.Id("race"));
        SelectElement selectRace = new SelectElement(selectWebElement3);
        selectRace.SelectByValue("O");
        Thread.Sleep(2000);
        
        IWebElement weightBody = Driver.FindElement(By.Name("mass"));
        weightBody.SendKeys("65");
        IWebElement height = Driver.FindElement(By.Id("grow"));
        height.SendKeys("165");
        IWebElement button = Driver.FindElement(By.Name("Рассчитать"));
        
        button.Click();
        Thread.Sleep(2000);
        IWebElement result = Driver.FindElement(By.Id("result"));
        IWebElement result1 = Driver.FindElement(By.Id("mdrd_res"));
        Assert.That(result1.Text, Is.EqualTo("0.07"));
    }
}