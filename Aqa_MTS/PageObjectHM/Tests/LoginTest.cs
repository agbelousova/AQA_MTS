using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Pages;
using PageObjectHM.Steps;

namespace PageObjectHM.Tests;

public class LoginTest : BaseTest
{
    [Test]
    [Category("PositiveLoginTest")]
    [Category("Steps")]
    public void SuccessLoginStepTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        Assert.That(NavigationSteps.CatalogPage.IsPageOpened());
    }
    [Test]
    [Category("NegativeIncorrectLoginTest")]
    [Category("Steps")]
    public void IncorrectLoginStepTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }

    [Test]
    [Category("Steps")]
    [Category("NegativeLockedUserLoginTest")]
    public void LockedUserLoginStepTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
    
    [Test]
    [Category("PositiveLoginTest")]
    [Category("Page")]
    public void SuccessLoginPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        CatalogPage catalogPage = new CatalogPage(Driver);
        Assert.That(catalogPage.IsPageOpened);
    }

    [Test]
    [Category("NegativeIncorrectLoginTest")]
    [Category("Page")]
    public void IncorrectLoginPageTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    
    [Test]
    [Category("NegativeLockedUserLoginTest")]
    [Category("Page")]
    public void LockedUserLoginPageTest()
    {
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}