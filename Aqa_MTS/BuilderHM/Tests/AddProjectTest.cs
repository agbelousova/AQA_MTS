using BuilderHM.Models;
using BuilderHM.Pages;

namespace BuilderHM.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        Project expectedProject = new Project.Builder()
            .SetProjectName("Test")
            .SetAnnouncement("Announcement")
            .SetShowAnnouncement(true)
            .SetProjectType(1)
            .SetTestCaseApprovals(true)
            .Build();

        ProjectsPage _projectsPage = _projectSteps.AddProject(expectedProject);
        Assert.That(_projectsPage.ProjectsTable.GetCell("Project", expectedProject.ProjectName, 0).GetLink().Enabled);
    }
}