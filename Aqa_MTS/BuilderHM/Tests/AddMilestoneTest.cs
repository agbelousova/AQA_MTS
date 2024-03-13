using BuilderHM.Elements;
using BuilderHM.Models;
using BuilderHM.Pages;
using BuilderHM.Steps;
using OpenQA.Selenium;

namespace BuilderHM.Tests;

public class AddMilestoneTest : BaseTest
{
    [Test]
    public void AddMilestoneBuilderTest()
    {
        Random random = new Random();
       _navigationSteps.SuccessfulLogin(Admin);

       ProjectsPage projectsPage = new ProjectsPage(Driver, true);

       TableCell tableCell = projectsPage.ProjectsTable.GetCell("Project", "Test", "Project");
       tableCell.GetOverviewLink().Click();

       Milestone _milestone = new Milestone.Builder()
           .SetName($"Test Milestone_{random.Next(15)}")
           .SetReferences($"Test References {random.Next(15)}")
           .SetDescription($"Test Description {random.Next(15)}")
           .SetMilestoneCompleted(true)
           .Build();

       _projectSteps.AddMilestone(_milestone);
       
       IWebElement result = Driver.FindElement(By.ClassName("message-success"));
       Assert.That(result.Text.Trim(), Is.EqualTo("Successfully added the new milestone."));
    }
}