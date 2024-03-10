using OpenQA.Selenium;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Pages.ProjectPages;

namespace ChainOfInvocations.Steps;

public class BaseSteps(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;
    
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}