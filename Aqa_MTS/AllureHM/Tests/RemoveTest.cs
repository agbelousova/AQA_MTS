using Allure.Net.Commons;
using AllureHM.Helpers.Configuration;
using AllureHM.Pages;
using AllureHM.Steps;
using NUnit.Allure.Attributes;

namespace AllureHM.Tests;

public class RemoveTest:BaseTest
{
    [Test(Description = "Удаление товара из корзины.")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Page")]
    public void RemovePageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        CatalogPage catalogPage = loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        
        AllureApi.Step("нажимаем кнопку Add to Product");
        catalogPage.AddProduct();
        TakeScreenshot("товар добавлен в корзину");
        AllureApi.Step("нажимаем кнопку Remove Product");
        catalogPage.RemoveProduct();
        TakeScreenshot("товар удален из корзины");
        
        Assert.That(catalogPage.AddProductButton.Displayed);
        TakeScreenshot("товар снова доступен для покупки");
    }

    [Test(Description = "Удаление товара из корзины.")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Steps")]
    public void RemoveStepsTest()
    {
        AllureApi.Step("проверка удаления товара из корзины");
        Assert.That(
            new NavigationSteps(Driver)
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProduct()
                .RemoveProduct()
                .AddProductButton
                .Displayed);
    }
}