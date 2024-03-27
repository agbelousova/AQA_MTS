using OpenQA.Selenium;
using TestRailCore.Core;
using TestRailCore.Helpers.Configuration;
using TestRailCore.Models;
using TestRailCore.Steps;

namespace TestRailBDD.Steps;

public class BaseSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext ScenarioContext { get; }
   // protected NavigationSteps _navigationSteps;
   // protected ProjectSteps _projectSteps;
    protected User Admin { get; private set; }
    public BaseSteps(Browser browser, ScenarioContext scenarioContext)
    {
        Driver = browser.Driver;
        ScenarioContext = scenarioContext;
        
      //  _navigationSteps = new NavigationSteps(Driver);
      //  _projectSteps = new ProjectSteps(Driver);

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }
}