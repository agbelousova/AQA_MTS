using OpenQA.Selenium;
using ValueOfObjectTest.Models;
using ValueOfObjectTest.Pages.ProjectPages;

namespace ValueOfObjectTest.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);
        
        AddProjectPage.NameInput.SendKeys(project.Name);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.SuiteMode);
        if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();
        
        AddProjectPage.AddButton.Click();
        
        return new ProjectsPage(Driver);
    }
}