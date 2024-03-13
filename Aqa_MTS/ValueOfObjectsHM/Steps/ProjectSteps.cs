using OpenQA.Selenium;
using ValueOfObjectsHM.Models;
using ValueOfObjectsHM.Pages;
using ValueOfObjectsHM.Pages.ProjectPages;
using ValueOfObjectsHM.Tests;

namespace ValueOfObjectsHM.Steps;

public class ProjectStep(IWebDriver driver) : BaseStep(driver)
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