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
    private ProjectTestCasePage _projectTestCase;
    
    public UserStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
        _projectSteps = new ProjectSteps(Driver);
        _projectsPage = new ProjectsPage(Driver);
        _projectMilestonesPage = new ProjectMilestonesPage(Driver);
        _projectTestCase = new ProjectTestCasePage(Driver);
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
    [Given(@"The user opened the created project and went to the advanced tab TestCase")]
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

    [When(@"The user created TestCase")]
    public void UserCreatedTestCase()
    {
        TestCase testCase = new TestCase()
        {
            InputTitle = "Test Case",
            TemplateDropDown = 2,
            TypeDropDown = 3,
            PriorityDropDown = 1,
            AssignedToDropDown = 1,
            StepsInput = "StepsInput"
        };

        _projectSteps.AddTestCase(testCase);
    }

    [Then(@"TestCase successfully created")]
    public void ThenTestCaseSuccessfullyCreated()
    {
        Assert.That(_projectTestCase.SuccessMessage.Text.Trim(), 
            Is.EqualTo("Successfully added the new test case. Add another"));
    }
}