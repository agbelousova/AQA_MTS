using ChainOfInvocationsTest.Pages;
using OpenQA.Selenium;

namespace ChainOfInvocationsTest.Steps;

public class ProjectsSteps(IWebDriver driver) : BaseSteps(driver)
{
    public ProjectsPage AddProject(string projectName, string announcement, bool checkAnnouncement, int suiteMode, bool checkCaseStatuses)
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