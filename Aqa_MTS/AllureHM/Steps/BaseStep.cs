using OpenQA.Selenium;
using AllureHM.Pages;
using NUnit.Allure.Core;

namespace AllureHM.Steps;
[AllureNUnit]
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