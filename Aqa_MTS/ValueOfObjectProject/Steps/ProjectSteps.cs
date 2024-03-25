using OpenQA.Selenium;
using ValueOfObjectProject.Models;
using ValueOfObjectProject.Pages.ProjectPages;

namespace ValueOfObjectProject.Steps;

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