using OpenQA.Selenium;

namespace AllureHM.Pages;

public class CheckoutCompletePage: BasePage
{
    private static string END_POINT = "/checkout-complete.html";
    
    private static readonly By BackToProductsButtonBy = By.Id("back-to-products");
    public CheckoutCompletePage(IWebDriver driver) : base(driver)
    {
    }

    public CheckoutCompletePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    protected override string GetEndpoint()
    {
        return END_POINT;
    }

    public override bool IsPageOpened()
    {
        try
        {
            return BackToProductsButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    public IWebElement BackToProductsButton => WaitsHelper.WaitForExists(BackToProductsButtonBy);
    
}