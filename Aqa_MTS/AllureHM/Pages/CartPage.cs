using OpenQA.Selenium;
using AllureHM.Helpers;

namespace AllureHM.Pages;

public class CartPage : BasePage
{
    private static string END_POINT = "/cart.html";
    
    private static readonly By CheckoutButtonBy = By.Id("checkout");
    private static readonly By ContinueShoppingButtonBy = By.Id("continue-shopping");
    
    public CartPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CartPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return CheckoutButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }
    
    public IWebElement CheckoutButton => WaitsHelper.WaitForExists(CheckoutButtonBy);
    public IWebElement ContinueShoppingButton => WaitsHelper.WaitForExists(ContinueShoppingButtonBy);
    
    public CheckoutStepOnePage CheckoutProduct()
    { 
        CheckoutButton.Click();
        return new CheckoutStepOnePage(Driver);
    }
}