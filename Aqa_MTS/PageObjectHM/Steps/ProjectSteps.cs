using OpenQA.Selenium;
using PageObjectHM.Pages.ProjectPages;

namespace PageObjectHM.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectSteps(IWebDriver driver) : base(driver)
    {
    }

    public void NavigateToAddProjectPage()
    {
        new AddProjectPage(Driver, true);
    }
}