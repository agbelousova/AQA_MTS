using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Pages;
using PageObjectHM.Steps;

namespace PageObjectHM.Tests;

public class PaymentTest:BaseTest
{
    [Test]
    [Category("PaymentTest")]
    [Category("Page")]
    public void PaymentPageTest()
    {
        LoginPage loginPage = new LoginPage(Driver);
        CatalogPage catalogPage = loginPage.SuccessFulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);

        catalogPage.AddProduct();
        catalogPage.ShoppingCartBadge.Click();
        CartPage cartPage = new CartPage(Driver);
        CheckoutStepOnePage checkoutStepOnePage = cartPage.CheckoutProduct();
        CheckoutStepTwoPage checkoutStepTwoPage = checkoutStepOnePage.ContinueProduct();
        CheckoutCompletePage checkoutCompletePage = checkoutStepTwoPage.CheckoutComplete();

        Assert.That(checkoutCompletePage.BackToProductsButton.Displayed);
    }

    [Test]
    [Category("PaymentTest")]
    [Category("Steps")]
    public void PaymentStepsTest()
    {
        Assert.That(NavigationSteps.PaymentProduct());
    }
}