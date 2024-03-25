using OpenQA.Selenium;
using ValueOfObjectProject.Pages;
using ValueOfObjectProject.Pages.ProjectPages;

namespace ValueOfObjectProject.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;

    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}