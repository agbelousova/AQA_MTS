using OpenQA.Selenium;
using TestRailCore.Models;
using TestRailCore.Pages;
using TestRailCore.Pages.ProjectPages;

namespace TestRailCore.Steps;

public class ProjectSteps : BaseStep
{
    private ProjectsPage _projectsPage;
    private AddProjectPage _addProjectPage;
    private AddMilestonePage _addMilestonePage;
    private DashboardPage _dashboardPage;
    private AddTestCasePage _addTestCase;
    private AddTestSuitePage _addTestSuite;
    private ProjectTestSuitePage _projectTestSuitePage;

    public ProjectSteps(IWebDriver driver) : base(driver)
    {
        _projectsPage = new ProjectsPage(driver);
        _addProjectPage = new AddProjectPage(driver);
        _addMilestonePage = new AddMilestonePage(driver);
        _dashboardPage = new DashboardPage(driver);
        _addTestCase = new AddTestCasePage(driver);
        _addTestSuite = new AddTestSuitePage(driver);
        _projectTestSuitePage = new ProjectTestSuitePage(driver);
    }
    
    public ProjectsPage AddProject(Project project)
    {
        _projectsPage.AddProjectButton.Click();
        _addProjectPage.NameInput.SendKeys(project.NameInput);
        _addProjectPage.AnnouncementTextArea.SendKeys(project.AnnouncementInput);
        _addProjectPage.TypeRadioButton.SelectByIndex(project.ProjectTypeRadio);
        _addProjectPage.ShowAnnouncementCheckbox.Click();
        _addProjectPage.CaseApprovalsCheckbox.Click();
        _addProjectPage.AddButton.Click();
        
        return new ProjectsPage(Driver);
    }

    public AddMilestonePage AddMilestone(Milestone milestone)
    {
        _projectsPage.AddMilestoneButton.Click();
        _addMilestonePage.NameInput.SendKeys(milestone.NameInput);
        _addMilestonePage.ReferenceInput.SendKeys(milestone.ReferenceInput);
        _addMilestonePage.DescriptionInput.SendKeys(milestone.DescriptionInput);
        _addMilestonePage.IsCompleted.Click();
        _addMilestonePage.AddButton.Click();

        return new AddMilestonePage(Driver);
    }

    public AddTestCasePage AddTestCase(TestCase testcase)
    {
        _projectsPage.AddTestSuiteButton.Click();
        _addTestSuite.DescriptionInput.SendKeys("Description TestSuite");
        _addTestSuite.NameInput.SendKeys("TestSuite");
        _addTestSuite.AddButton.Click();
        _projectTestSuitePage.ClickAddTestCaseButton();
        _addTestCase.TitleInput.SendKeys(testcase.InputTitle);
        _addTestCase.TypeDropDown.SelectIndex(testcase.TypeDropDown);
        _addTestCase.PriorityDropDown.SelectIndex(testcase.PriorityDropDown);
        _addTestCase.AssignedToDropDown.SelectIndex(testcase.AssignedToDropDown);
        _addTestCase.StepsInput.SendKeys(testcase.StepsInput);
        _addTestCase.ClickAddButton();
        
        return new AddTestCasePage(Driver);
    }
}