using OpenQA.Selenium;
using ValueOfObjectsHM.Pages;
using ValueOfObjectsHM.Pages.ProjectPages;

namespace ValueOfObjectsHM.Steps;

public class BaseStep(IWebDriver driver)
{
    protected readonly IWebDriver Driver = driver;
    
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}