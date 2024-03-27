using OpenQA.Selenium;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;

namespace TestRailCore.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}