using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvanced.Helpers;

namespace SeleniumAdvanced.Tests;

public class WaitsTest : BaseTest
{
    [Test]
    public void PresenceOfElementTest() {
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");

        IWebElement button = Driver.FindElement(By.TagName("button"));
        button.Click();
        Assert.IsTrue(button.Displayed);

        IWebElement loading = Driver.FindElement(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        Assert.IsFalse(loading.Displayed);

        Assert.IsTrue(Driver.FindElement(By.Id("finish")).Displayed);
    }

    [Test]
    public void PresenceOfElementTest1() {
        WaitsHelper waitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(7));
        Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/1");
        
        IWebElement button = waitsHelper.WaitForVisibilityLocatedBy(By.TagName("button"));
        button.Click();
        Assert.IsTrue(waitsHelper.WaitForElementInvisible(button));

        IWebElement loading = waitsHelper.WaitForVisibilityLocatedBy(By.Id("loading"));
        Assert.IsTrue(loading.Displayed);
        Assert.IsTrue(waitsHelper.WaitForElementInvisible(loading));

        Assert.IsTrue(waitsHelper.WaitForVisibilityLocatedBy(By.Id("finish")).Displayed);
    }
}