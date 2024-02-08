using PageObjectSimple.Core;
using PageObjectSimple.Helpers;
using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Steps;
using OpenQA.Selenium;

namespace PageObjectSimple.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }

    protected NavigationSteps NavigationSteps;
    protected ProjectSteps ProjectSteps;

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;
        WaitsHelper = new WaitsHelper(Driver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
        
        // Инициализация Steps
        NavigationSteps = new NavigationSteps(Driver);
        ProjectSteps = new ProjectSteps(Driver);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}