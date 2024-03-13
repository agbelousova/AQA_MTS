using ChainOfInvocationHM.Pages;
using OpenQA.Selenium;

namespace ChainOfInvocationHM.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProjects(string projectName, string announcement, bool checkAnnouncement, int suiteMode, bool checkCaseStatuses)
    {
        DashboardPage dashboardPage = new DashboardPage(Driver);

        return dashboardPage
            .ClickSidebarProjectsAddButton()
            .InputNameValue(projectName)
            .InputAnnouncementValue(announcement)
            .CheckShowAnnouncementCheckbox(checkAnnouncement)
            .ChooseProjectType(suiteMode)
            .CheckCaseApprovalsCheckbox(checkCaseStatuses)
            .ClickAddButton();
    }
}