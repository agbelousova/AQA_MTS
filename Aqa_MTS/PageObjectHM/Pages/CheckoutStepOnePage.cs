using OpenQA.Selenium;

namespace PageObjectHM.Pages;

public class CheckoutStepOnePage: BasePage
{
    private static string END_POINT = "/checkout-step-one.html";
    
    private static readonly By ContinueButtonBy = By.Id("continue");
    private static readonly By FirstNameInputBy = By.Id("first-name");
    private static readonly By LastNameInputBy = By.Id("last-name");
    private static readonly By PostalCodeInputBy = By.Id("postal-code");
    public CheckoutStepOnePage(IWebDriver driver) : base(driver)
    {
    }

    public CheckoutStepOnePage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
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
            return ContinueButton.Displayed;
        }
        catch (Exception)
        {
            return false;
        }
    }
    
    public IWebElement ContinueButton => WaitsHelper.WaitForExists(ContinueButtonBy);
    public IWebElement FirstNameInput => WaitsHelper.WaitForExists(FirstNameInputBy);
    public IWebElement LastNameInput => WaitsHelper.WaitForExists(LastNameInputBy);
    public IWebElement PostalCodeInput => WaitsHelper.WaitForExists(PostalCodeInputBy);
    
    public CheckoutStepTwoPage ContinueProduct(string firstname, string lastname, string postalcode)
    { 
        FirstNameInput.SendKeys(firstname);
        LastNameInput.SendKeys(lastname);
        PostalCodeInput.SendKeys(postalcode);
        ContinueButton.Click();
        return new CheckoutStepTwoPage(Driver);
    }
}