using OpenQA.Selenium;
using PageObjectHM.Helpers.Configuration;

namespace PageObjectHM.Steps;

public class ProductSteps : BaseStep
{
    private NavigationSteps _navigationSteps;
    public ProductSteps(IWebDriver driver) : base(driver)
    {
        _navigationSteps = new NavigationSteps(Driver);
    }
    public bool PaymentProduct()
    {
        _navigationSteps.SuccessfulLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        _navigationSteps.NavigateToCatalogPage().AddProduct().ShoppingCartBadge.Click();
        _navigationSteps.NavigateToCartPage().CheckoutProduct();
        _navigationSteps.NavigateToCheckoutStepOnePage().ContinueProduct("Nastya", "Svist", "256102");
        _navigationSteps.NavigateToCheckoutStepTwoPage().CheckoutComplete();
        return _navigationSteps.NavigateToCheckoutCompletePage().BackToProductsButton.Displayed;
    }
}