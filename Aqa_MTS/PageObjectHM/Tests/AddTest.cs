using PageObjectHM.Pages;
using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Steps;

namespace PageObjectHM.Tests;

public class AddTest : BaseTest
{
    [Test]
    [Category("AddTest")]
    [Category("Page")]
    public void AddPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        CatalogPage catalogPage =
            loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        catalogPage.AddProduct();

        Assert.Multiple(() =>
        {
            Assert.That(catalogPage.ShoppingCartBadge.Text, Is.EqualTo("1"));
            Assert.That(catalogPage.RemoveProductButton.Displayed);
        });
    }

    [Test]
    [Category("AddTest")]
    [Category("Steps")]
    public void AddStepsTest()
    {
        Assert.That(
            new NavigationSteps(Driver)
                .SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password)
                .AddProduct()
                .ShoppingCartBadge.Text,
            Is.EqualTo("1"));
    }
}