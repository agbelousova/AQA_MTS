using NUnit.Framework;
using OpenQA.Selenium;
using ValueOfObjectProject.Core;
using ValueOfObjectProject.Helpers;
using ValueOfObjectProject.Helpers.Configuration;
using ValueOfObjectProject.Models;
using ValueOfObjectProject.Steps;

namespace ValueOfObjectProject.Tests;

[Parallelizable(scope: ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class BaseTest
{
    protected IWebDriver Driver { get; private set; }

    protected NavigationSteps _navigationSteps;
    protected ProjectSteps _projectSteps;

    protected User Admin { get; private set; }
    protected Project project;

    [OneTimeSetUp]
    public void OneTimeSetup()
    {
        if (Configurator.Language.ToLower().Equals("en"))
        {
            project = JsonHelper.ProjectFromJson(@"Resources/project_en.json");            
        }
        else
        {
            project = JsonHelper.ProjectFromJson(@"Resources/project_rus.json");            
        }
    }
    
    [SetUp]
    public void Setup()
    {
        Driver = new Browser().Driver;

        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);

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