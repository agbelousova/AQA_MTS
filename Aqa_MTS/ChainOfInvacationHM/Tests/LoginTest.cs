using ChainOfInvocationHM.Helpers.Configuration;
using ChainOfInvocationHM.Pages;

namespace ChainOfInvocationHM.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessfulLoginTest()
    {
        DashboardPage dashboardPage = NavigationSteps
            .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        Assert.That(dashboardPage.IsPageOpened);
    }
    
    [Test]
    public void InvalidUsernameLoginTest()
    {
        // Проверка
        Assert.That(
            NavigationSteps
                .IncorrectLogin("ssdd", "12345")
                .GetErrorLabelText(),
            Is.EqualTo("Email/Login or Password is incorrect. Please try again."));
    }
}