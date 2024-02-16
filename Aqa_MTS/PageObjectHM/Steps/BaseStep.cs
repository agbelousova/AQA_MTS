using OpenQA.Selenium;
using PageObjectHM.Pages;

namespace PageObjectHM.Steps;

public class BaseStep
{
    protected IWebDriver Driver;

    public LoginPage LoginPage => new LoginPage(Driver);
    public CatalogPage CatalogPage => new CatalogPage(Driver);
    public CartPage CartPage => new CartPage(Driver);
    public CheckoutCompletePage CheckoutCompletePage => new CheckoutCompletePage(Driver);
    public CheckoutStepOnePage CheckoutStepOnePage => new CheckoutStepOnePage(Driver);
    public CheckoutStepTwoPage CheckoutStepTwoPage => new CheckoutStepTwoPage(Driver);

    public BaseStep(IWebDriver driver)
    {
        Driver = driver;
    }
}