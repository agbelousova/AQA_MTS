using OpenQA.Selenium;
using Wrappers.Pages;
using Wrappers.Pages.ProjectPages;

namespace Wrappers.Steps;

public class BaseStep
{
    protected IWebDriver Driver;
    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}