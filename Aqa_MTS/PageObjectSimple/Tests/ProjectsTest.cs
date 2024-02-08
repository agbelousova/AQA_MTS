using PageObjectSimple.Helpers.Configuration;
using PageObjectSimple.Steps;

namespace PageObjectSimple.Tests;

public class ProjectsTest : BaseTest
{
    
    [Test]
    public void CreateProjectTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        ProjectSteps.NavigateToAddProjectPage();
    }
    
}