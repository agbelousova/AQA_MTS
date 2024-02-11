using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Pages;
using PageObjectHM.Steps;

namespace PageObjectHM.Tests;

public class LoginTest : BaseTest
{
    [Test]
    public void SuccessLoginStepTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        Assert.That(NavigationSteps.DashboardPage.IsPageOpened());
    }
    [Test]
    public void IncorrectLoginStepTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }

    [Test]
    public void LockedUserLoginStepTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
    
    [Test]
    public void SuccessLoginPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        DashboardPage dashboardPage = new DashboardPage(Driver);
        Assert.That(dashboardPage.IsPageOpened);
    }

    [Test]
    public void IncorrectLoginPageTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    
    [Test]
    public void LockedUserLoginPageTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }

    [Test]
    public void AddProductPageTest()
    {
        Assert.That(
            new DashboardPage(Driver)
                .AddProduct().Basket.Text.Trim(),
            Is.EqualTo("1"));
    }
}