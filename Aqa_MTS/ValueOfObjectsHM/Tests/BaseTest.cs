using ChainOfInvocationHM.Steps;
using OpenQA.Selenium;
using ValueOfObjectsHM.Core;
using ValueOfObjectsHM.Helpers.Configuration;
using ValueOfObjectsHM.Models;
using NavigationSteps = ValueOfObjectsHM.Steps.NavigationSteps;
using ProjectsStep = ValueOfObjectsHM.Steps.ProjectStep;

namespace ValueOfObjectsHM.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

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