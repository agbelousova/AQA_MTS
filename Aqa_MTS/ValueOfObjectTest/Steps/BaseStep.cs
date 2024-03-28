using OpenQA.Selenium;
using ValueOfObjectTest.Pages;
using ValueOfObjectTest.Pages.ProjectPages;

namespace ValueOfObjectTest.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}