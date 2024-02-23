using OpenQA.Selenium;

namespace AllureHM.Pages;

public class CheckoutStepTwoPage: BasePage
{
    private static string END_POINT = "/checkout-step-two.html";
    
    private static readonly By FinishButtonBy = By.Id("finish");
    public CheckoutStepTwoPage(IWebDriver driver) : base(driver)
    {
    }

    public CheckoutStepTwoPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
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
            return FinishButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    public IWebElement FinishButton => WaitsHelper.WaitForExists(FinishButtonBy);
    
    public CheckoutCompletePage CheckoutComplete()
    { 
        FinishButton.Click();
        return new CheckoutCompletePage(Driver);
    }
}