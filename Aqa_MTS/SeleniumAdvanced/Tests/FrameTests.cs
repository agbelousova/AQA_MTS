using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvanced.Tests;

namespace NUnitTest.Tests;

public class SeleniumAdvanced : BaseTest
{
    [Test]
    public void FrameTest() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/iframe");

        //Driver.SwitchTo().Frame(Driver.FindElement(By.id("mce_0_ifr")));
        //Driver.SwitchTo().Frame(0);
        Driver.SwitchTo().Frame("mce_0_ifr");  //значение ИД или Name атрибута
        Assert.That(Driver.FindElement(By.Id("tinymce")).Displayed); //возврат на 1 фрэйм выше 
        //Driver.SwitchTo().DefaultContent(); // возврат в родительскиий документ в начало документа

        Driver.SwitchTo().ParentFrame();
        Assert.That(Driver.FindElement(By.ClassName("tox-editor-container")).Displayed);
    }
}