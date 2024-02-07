using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Helpers.Configuration;

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
        Driver.SwitchTo().Frame(0);
        IWebElement age = Driver.FindElement(By.Id("age"));
        IWebElement selectWebElement1 = Driver.FindElement(By.Id("sex"));
        IWebElement creatinin = Driver.FindElement(By.Name("cr"));
        IWebElement selectWebElement2 = Driver.FindElement(By.Id("cr-size"));
        IWebElement selectWebElement3 = Driver.FindElement(By.Id("race"));
        IWebElement weightBody = Driver.FindElement(By.Name("mass"));
        IWebElement height = Driver.FindElement(By.Id("grow"));
        IWebElement button = Driver.FindElement(By.XPath("//button[text()='Рассчитать']"));
        
        age.SendKeys("30");
        SelectElement selectSex = new SelectElement(selectWebElement1);
        selectSex.SelectByValue("F");
        creatinin.SendKeys("34");
        SelectElement selectCrSize = new SelectElement(selectWebElement2);
        selectCrSize.SelectByValue("mm");
        SelectElement selectRace = new SelectElement(selectWebElement3);
        selectRace.SelectByValue("O");
        weightBody.SendKeys("65");
        height.SendKeys("165");
        
        button.Click();
        Thread.Sleep(2000);
        IWebElement result1 = Driver.FindElement(By.Id("mdrd_res"));
        IWebElement result2 = Driver.FindElement(By.TagName("i"));
        IWebElement result3 = Driver.FindElement(By.ClassName("diagnosis"));
        IWebElement result4 = Driver.FindElement(By.Id("ckd_epi_res"));
        IWebElement result5 = Driver.FindElement(By.XPath("//*[@id=\"ckd_epi\"]/p/i"));
        IWebElement result6 = Driver.FindElement(By.XPath("//*[@id=\"ckd_epi\"]/p/span"));
        
        Assert.Multiple(() =>
        {
            Assert.That(result1.Text, Is.EqualTo("0.07"));
            Assert.That(result2.Text, Is.EqualTo("мл/мин/1.73м2"));
            Assert.That(result3.Text, Is.EqualTo("Терминальная почечная недостаточность (C5)"));
            Assert.That(result4.Text, Is.EqualTo("0.06"));
            Assert.That(result5.Text, Is.EqualTo("мл/мин/1.73м2"));
            Assert.That(result6.Text, Is.EqualTo("Терминальная почечная недостаточность (C5)"));
        });
    }
}