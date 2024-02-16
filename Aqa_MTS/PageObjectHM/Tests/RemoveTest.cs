using PageObjectHM.Pages;
using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Steps;
using PageObjectHM.Tests;

public class RemoveTest:BaseTest
{
    [Test]
    [Category("RemoveTest")]
    [Category("Page")]
    public void RemovePageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        CatalogPage catalogPage = loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        catalogPage.AddProduct();
        catalogPage.RemoveProduct();
        
        Assert.That(catalogPage.AddProductButton.Displayed);
    }

    [Test]
    [Category("RemoveTest")]
    [Category("Steps")]
    public void RemoveStepsTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProduct()
                .RemoveProduct()
                .AddProductButton
                .Displayed);
    }
}