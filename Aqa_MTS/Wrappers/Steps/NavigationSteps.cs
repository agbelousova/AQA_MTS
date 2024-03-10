using NUnit.Allure.Attributes;
using OpenQA.Selenium;
using Wrappers.Pages;

namespace Wrappers.Steps;

public class NavigationSteps : BaseStep
{
    public NavigationSteps(IWebDriver driver) : base(driver)
    {
    }
}