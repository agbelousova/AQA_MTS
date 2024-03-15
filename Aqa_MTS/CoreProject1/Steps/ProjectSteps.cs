using CoreProject1.Models;
using CoreProject1.Pages.ProjectPages;
using OpenQA.Selenium;

namespace CoreProject1.Steps;

public class ProjectSteps(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(Driver, true);
        
        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        if (project.IsShowAnnouncement != null) AddProjectPage.ShowAnnouncementCheckBox.Click();
        
        AddProjectPage.AddButton.Click();
        
        return new ProjectsPage(Driver);
    }
}