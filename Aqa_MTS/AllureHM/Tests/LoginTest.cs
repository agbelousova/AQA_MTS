using Allure.Net.Commons;
using AllureHM.Helpers.Configuration;
using AllureHM.Pages;
using AllureHM.Steps;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace AllureHM.Tests;

public class LoginTest : BaseTest
{
    [Test(Description = "Проверка успешного логина")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Steps")]
    public void SuccessLoginStepTest()
    {
        NavigationSteps.NavigateToLoginPage();
        NavigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        AllureApi.Step("после логина открылась страница каталога");
        Assert.That(NavigationSteps.CatalogPage.IsPageOpened());
    }
    
    [Test(Description = "Проверка не успешного логина")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Steps")]
    public void IncorrectLoginStepTest()
    {
        AllureApi.Step("проверка получения ожидаемой ошибки");
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }

    [Test(Description = "Проверка не успешного логина - LockedUser")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Steps")]
    public void LockedUserLoginStepTest()
    {
        AllureApi.Step("проверка получения ожидаемой ошибки");
        Assert.That(
            new NavigationSteps(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
    
    [Test(Description = "Проверка успешного логина")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Page")]
    public void SuccessLoginPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        AllureApi.Step("ввод логина и пароля");
        loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        CatalogPage catalogPage = new CatalogPage(Driver);
        AllureApi.Step("после логина открылась страница каталога");
        Assert.That(catalogPage.IsPageOpened);
    }

    [Test(Description = "Проверка не успешного логина")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Page")]
    public void IncorrectLoginPageTest()
    {
        AllureApi.Step("проверка получения ожидаемой ошибки");
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("login", "qwerty")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
    }
    
    [Test(Description = "Проверка не успешного логина - LockedUser")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Page")]
    public void LockedUserLoginPageTest()
    {
        AllureApi.Step("проверка получения ожидаемой ошибки");
        Assert.That(
            new LoginPage(Driver)
                .IncorrectLogin("locked_out_user", "secret_sauce")
                .ErrorLabel.Text.Trim(),
            Is.EqualTo("Epic sadface: Sorry, this user has been locked out."));
    }
}