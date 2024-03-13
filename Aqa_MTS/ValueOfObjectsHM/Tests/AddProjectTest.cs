using ValueOfObjectsHM.Models;

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
        
        Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}