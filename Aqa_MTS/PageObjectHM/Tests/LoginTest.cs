using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Pages;

namespace PageObjectHM.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginStepTest()
    {
        NavigationSteps.NavigateToLoginPage();
    //    NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(NavigationSteps.DashboardPage.IsPageOpened());
    }

    [Test]
    public void SuccessLoginPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        DashboardPage dashboardPage = new DashboardPage(Driver);
        Assert.That(dashboardPage.IsPageOpened);
    }
}