using NUnit.Framework;
using OpenQA.Selenium;
using TestRailCore.Core;
using TestRailCore.Elements;
using TestRailCore.Models;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;
using TestRailCore.Steps;

namespace TestRailBDD.Steps;

[Binding]
public class UserStepDefs : BaseSteps
{
    private NavigationSteps _navigationSteps;
    private ProjectSteps _projectSteps;
    private ProjectsPage _projectsPage;
    private ProjectMilestonesPage _projectMilestonesPage;
    
    public UserStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);
        _projectsPage = new ProjectsPage(Driver);
        _projectMilestonesPage = new ProjectMilestonesPage(Driver);
    }
    [Given(@"The admin user is logged in")]
    public void AdminUserLoggedIn()
    {
        _navigationSteps.SuccessfulLogin(Admin);
    }

    [Given(@"The user has created a project")]
    public void UserCreatedProject()
    {
        Project project = new Project()
        {
            NameInput = "ProjectTest",
            AnnouncementInput = "AnnouncementTest",
            ShowAnnouncementCheckbox = true,
            ProjectTypeRadio = 2,
            CaseApprovalsCheckbox = true
        };

        _projectSteps.AddProject(project);
    }

    [Given(@"The user opened the created project and went to the advanced tab Milestone")]
    public void UserOpenedCreatedProjectAndAdvancedMilestone()
    {
        TableCell tableCell = _projectsPage.ProjectsTable
            .GetCell("Project", "ProjectTest", "Project");
        tableCell.GetOverviewLink().Click();
    }

    [When(@"The user created Milestone")]
    public void UserCreatedMilestone()
    {
        Milestone milestone = new Milestone()
            {
                NameInput = "Test Milestone",
                ReferenceInput = "true",
                DescriptionInput = "Milestone 1",
                IsCompleted = true
            };

        _projectSteps.AddMilestone(milestone);
    }

    [Then(@"Milestone successfully created")]
    public void MilestoneSuccessfullyCreated()
    {
        Assert.That(_projectMilestonesPage.SuccessMessage.Text.Trim(), Is.EqualTo("Successfully added the new milestone."));
    }
}