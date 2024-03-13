using ChainOfInvocationHM.Helpers.Configuration;
using ChainOfInvocationHM.Pages;

namespace ChainOfInvocationHM.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
    public void SuccessAddProjectTest()
    {
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        ProjectsPage projectsPage = ProjectSteps.AddProjects(
            "Project",
            "Test",
            true,
            1,
            true);

        Assert.That(projectsPage.ProjectsTable.GetCell("Project", "Project", 0).GetLink().Enabled);
    }
}