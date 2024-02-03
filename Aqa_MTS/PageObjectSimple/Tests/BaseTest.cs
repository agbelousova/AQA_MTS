using OpenQA.Selenium;
using PageObjectSimple.Core;
using PageObjectSimple.Helpers;
using PageObjectSimple.Helpers.Configuration;

namespace PageObjectSimple.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver!;
       // Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}