using BuilderHM.Core;
using BuilderHM.Helpers;
using BuilderHM.Helpers.Configuration;
using BuilderHM.Models;
using OpenQA.Selenium;
using NavigationSteps = BuilderHM.Steps.NavigationSteps;
using ProjectsStep = BuilderHM.Steps.ProjectStep;

namespace BuilderHM.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }
    protected WaitsHelper WaitsHelper { get; private set; }
    protected NavigationSteps _navigationSteps;
    protected ProjectsStep _projectSteps;

    protected User Admin { get; private set; }

    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectsStep(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }

    [TearDown]
    public void TearDown()
    {
        Driver.Quit();
    }
}