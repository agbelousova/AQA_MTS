using BuilderHM.Models;
using BuilderHM.Pages;
using BuilderHM.Pages.ProjectPages;
using OpenQA.Selenium;

namespace BuilderHM.Steps;

public class ProjectStep(IWebDriver driver) : BaseStep(driver)
{
    public ProjectsPage AddProject(Project project)
    {
        DashboardPage _dashboardPage = new DashboardPage(Driver);

        return _dashboardPage
            .ClickSidebarProjectsAddButton()
            .InputNameValue(project.ProjectName)
            .InputAnnouncementValue(project.Announcement)
            .CheckShowAnnouncementCheckbox(project.IsShowAnnouncement)
            .ChooseProjectType(project.ProjectType)
            .CheckCaseApprovalsCheckbox(project.IsTestCaseApprovals)
            .ClickAddButton();
    }
    
    public ProjectMilestonesPage AddMilestone(Milestone milestone)
    {
        ProjectsPage projectPage = new ProjectsPage(Driver);

        return projectPage
            .ClickAddMilestoneButton()
            .InputName(milestone.Name)
            .InputReference(milestone.References)
            .InputDescription(milestone.Description)
            .CheckIsCompleted(milestone.MilestoneCompleted)
            .ClickAddButton();
    }
}