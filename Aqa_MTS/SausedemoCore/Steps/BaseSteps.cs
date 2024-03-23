using OpenQA.Selenium;
using SaucedemoCore.Core;

namespace SaucedemoCore.Steps;

public class BaseSteps
{
    protected IWebDriver Driver;

    public BaseSteps(IWebDriver driver)
    {
        Driver = driver;
    }
}