using OpenQA.Selenium;
using AllureHM.Helpers.Configuration;
using AllureHM.Pages;
using NUnit.Allure.Attributes;

namespace AllureHM.Steps;

public class NavigationSteps : BaseStep
{
    private LoginPage _loginPage;

    public NavigationSteps(IWebDriver driver) : base(driver)
    {
        _loginPage = new LoginPage(Driver);
    }
    
    [AllureStep("Переходим на страницу авторизации")]
    public LoginPage NavigateToLoginPage()
    {
        return new LoginPage(Driver);
    }
    
    [AllureStep("Переходим на страницу каталога товаров")]
    public CatalogPage NavigateToCatalogPage()
    {
        return new CatalogPage(Driver);
    }
    
    [AllureStep("Переходим в корзиину")]
    public CartPage NavigateToCartPage()
    {
        return new CartPage(Driver);
    }

    [AllureStep("Переходим на страницу ввода данных для оплаты")]
    public CheckoutStepOnePage NavigateToCheckoutStepOnePage()
    {
        return new CheckoutStepOnePage(Driver);
    }
    
    [AllureStep("Переходим на страницу подтверждения покупки")]
    public CheckoutStepTwoPage NavigateToCheckoutStepTwoPage()
    {
        return new CheckoutStepTwoPage(Driver);
    }
    
    [AllureStep("Покупка товара совершена")]
    public CheckoutCompletePage NavigateToCheckoutCompletePage()
    {
        return new CheckoutCompletePage(Driver);
    }
    
    [AllureStep("Переходим на страницу каталога - успешная авторизация")]
   public CatalogPage SuccessfulLogin(string username, string psw)
   {
       _loginPage.IncorrectLogin(username, psw);
        return new CatalogPage(Driver);
    }

   [AllureStep("Не успешная авторизация")]
    public LoginPage IncorrectLogin(string username, string psw)
    {
        Login(username, psw);
        Thread.Sleep(2000);
        return _loginPage;
    }

    [AllureStep("Ввод логина и пароля")]
    private void Login(string username, string psw)
    {
        _loginPage.LoginInput.SendKeys(username);
        _loginPage.PswInput.SendKeys(psw);
        _loginPage.LoginInButton.Click();
    }

    [AllureStep("Покупка товара")]
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