using Allure.Net.Commons;
using AllureHM.Helpers.Configuration;
using AllureHM.Pages;
using AllureHM.Steps;
using NUnit.Allure.Attributes;

namespace AllureHM.Tests;

public class PaymentTest:BaseTest
{
    [Test(Description = "Покупка товара. Товар успешно оплачен")]
    [AllureSeverity(SeverityLevel.normal)]
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

    [Test(Description = "Покупка товара. Товар успешно оплачен")]
    [AllureSeverity(SeverityLevel.normal)]
    [Category("Steps")]
    public void PaymentStepsTest()
    {
        Assert.That(NavigationSteps.PaymentProduct());
    }
}