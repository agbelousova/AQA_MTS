using NUnitTest.Core;
using OpenQA.Selenium;
using SeleniumBasic.Core;
using SeleniumBasic.Helpers.Configuration;

namespace SeleniumBasic.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new SimpleDriver().Driver;
        //Driver = new Browser().Driver!;
       // Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}