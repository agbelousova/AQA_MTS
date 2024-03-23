using SaucedemoCore.Core;
using OpenQA.Selenium;

namespace SaucedemoBDD.Steps;

public class BaseSteps
{
    protected IWebDriver Driver { get; }
    protected ScenarioContext ScenarioContext { get; }

    public BaseSteps(Browser browser, ScenarioContext scenarioContext)
    {
        Driver = browser.Driver;
        ScenarioContext = scenarioContext;
    }
}