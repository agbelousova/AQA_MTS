using OpenQA.Selenium;
using TestRailCore.Core;
using TestRailCore.Helpers.Configuration;
using TestRailCore.Models;

namespace TestRailBDD.Steps;

public class BaseSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext ScenarioContext { get; }
    protected User Admin { get; private set; }
    public BaseSteps(Browser browser, ScenarioContext scenarioContext)
    {
        Driver = browser.Driver;
        ScenarioContext = scenarioContext;

        Admin = new User
        {
            Email = Configurator.AppSettings.Username,
            Password = Configurator.AppSettings.Password
        };
        
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
    }
}