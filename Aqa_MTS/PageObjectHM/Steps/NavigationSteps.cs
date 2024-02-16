using OpenQA.Selenium;
using PageObjectHM.Helpers.Configuration;
using PageObjectHM.Pages;

namespace PageObjectHM.Steps;

public class NavigationSteps : BaseStep
{
    private LoginPage _loginPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }
    
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }
    
    public CatalogPage NavigateToCatalogPage()
    {
        return new CatalogPage(Driver);
    }
    
    public CartPage NavigateToCartPage()
    {
        return new CartPage(Driver);
    }

    public CheckoutStepOnePage NavigateToCheckoutStepOnePage()
    {
        return new CheckoutStepOnePage(Driver);
    }
    
    public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage()
    {
        return new CheckoutStepTwoPage(Driver);
    }
    
    public CheckoutCompletePage NavigateToCheckoutCompletePage()
    {
        return new CheckoutCompletePage(Driver);
    }
    
   public CatalogPage SuccessfulLogin(string username, string psw)
   {
       _loginPage.IncorrectLogin(username, psw);
        return new CatalogPage(Driver);
    }

    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        Thread.Sleep(2000);
        return _loginPage;
    }

    private void Login(string username, string psw)
    {
        _loginPage.LoginInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(psw);
        _loginPage.LoginInButton.Click();
    }

    public bool PaymentProduct()
    {
        Login(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
        NavigateToCatalogPage().AddProduct().ShoppingCartBadge.Click();
        NavigateToCartPage().CheckoutProduct();
        NavigateToCheckoutStepOnePage().ContinueProduct();
        NavigateToCheckoutStepTwoPage().CheckoutComplete();
        return NavigateToCheckoutCompletePage().BackToProductsButton.Displayed;
    }
}