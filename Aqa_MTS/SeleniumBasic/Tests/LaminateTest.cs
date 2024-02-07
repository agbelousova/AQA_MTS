using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumBasic.Tests;
public class LaminateTest : BaseTest
{
    [Test]
    public void CalcLaminateTest()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");

        IWebElement roomLength = Driver.FindElement(By.Id("ln_room_id"));
        IWebElement roomWidth = Driver.FindElement(By.Id("wd_room_id"));
        IWebElement lenghtPlashki = Driver.FindElement(By.Id("ln_lam_id"));
        IWebElement widthPlashki = Driver.FindElement(By.Id("wd_lam_id"));
        IWebElement quantityPlashki = Driver.FindElement(By.Id("n_packing"));
        IWebElement areaPacking = Driver.FindElement(By.Id("area"));
        IWebElement layingLaminate  = Driver.FindElement(By.CssSelector("label[for=direction-laminate-id1]"));
        IWebElement selectWebElement2 = Driver.FindElement(By.Id("laying_method_laminate"));
        
        roomLength.Clear();
        roomLength.SendKeys("1500");
        roomWidth.Clear();
        roomWidth.SendKeys("2500");
        lenghtPlashki.Clear();
        lenghtPlashki.SendKeys("1500");
        widthPlashki.Clear();
        widthPlashki.SendKeys("400");
        quantityPlashki.Clear();
        quantityPlashki.SendKeys("100");
        areaPacking.SendKeys("300");
        layingLaminate.Click();
        SelectElement selectCrSize = new SelectElement(selectWebElement2);
        selectCrSize.SelectByValue("0");
        
        Thread.Sleep(2000);
        Driver.FindElement(By.Id("btn_calculate")).Click();
        Thread.Sleep(2000);
        /*
        string result = Driver.FindElement(By.CssSelector(".calc-result")).Text;

        if (result.Contains("плашек ламината: 647") &&
            result.Contains("упаковок ламината: 7") &&
            result.Contains("0 руб") &&
            result.Contains("0 кг"))
            Assert.Pass();
        */
        Assert.That(Driver.FindElement(By.CssSelector(".calc-result")).Text.Replace("\r\n"," "), 
        Is.EqualTo("Требуемое количество плашек ламината: 647 Количество упаковок ламината: 7 Стоимость ламината: 0 руб Вес ламината: 0 кг"));
    }
}