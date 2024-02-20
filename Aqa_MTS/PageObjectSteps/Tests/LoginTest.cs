using PageObjectSteps.Helpers.Configuration;

namespace PageObjectSteps.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginTest()
    {
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(NavigationSteps.DashboardPage.IsPageOpened());
    }
}