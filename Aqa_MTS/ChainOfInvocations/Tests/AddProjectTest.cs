using ChainOfInvocations.Helpers.Configuration;
using ChainOfInvocations.Pages;
using ChainOfInvocations.Steps;
using NavigationSteps = ChainOfInvocations.Steps.NavigationSteps;

//using NavigationSteps = ChainOfInvocations.Steps.NavigationSteps;

namespace ChainOfInvocations.Tests;

public class AddProjectTest : BaseTest
{
    [Test]
        public void SuccessAddProjectTest()
        {
            Random random = new Random();
            string projectName = $"FeedTheCatProject_{random.Next(1000)}";

            NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

            ProjectsPage projectsPage = ProjectSteps.AddProject(
                "",
                "",
                true,
                2,
                true);
            
            ProjectsPage projectsPage1 = ProjectSteps.AddProject(
                projectName,
                $"TestProjectAnnouncemen_{random.Next(1000)}",
                random.Next(0, 1) == 0,
                random.Next(0, 2),
                random.Next(0, 1) == 0);

            Assert.That(projectsPage.ProjectsTable.GetCell("Project", projectName, 0).GetLink().Enabled);
        }
    }
}