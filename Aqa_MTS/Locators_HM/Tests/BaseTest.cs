using OpenQA.Selenium;
using Locators_HM.Core;
using Locators_HM.Helpers.Configuration;
using NUnit.Framework;

namespace Locators_HM.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver? Driver { get; set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
       // Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}