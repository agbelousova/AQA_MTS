using ValueOfObjectsHM.Models;
using ValueOfObjectsHM.Pages;

namespace ValueOfObjectsHM.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        Random random = new Random();
        _navigationSteps.SuccessfulLogin(Admin);

        Project expectedProject = new Project()
        {
            ProjectName = $"WP Test 01_{random.Next(100)}",
            Announcement = $"Test Details_{random.Next(100)}",
            IsShowAnnouncement = false,
            ProjectType = 1
        };

        ProjectsPage _projectsPage = _projectSteps.AddProject(expectedProject);
        Assert.That(_projectsPage.ProjectsTable.GetCell("Project", expectedProject.ProjectName, 0).GetLink().Enabled);
    }
}