using OpenQA.Selenium;

namespace SaucedemoCore.Pages;

public class ProductsPage : BasePage
{
    private static string END_POINT = "inventory.html";

    public HeaderPage HeaderPage;

    private static readonly By BackpackAddButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By BackpackRemoveButtonBy = By.Id("remove-sauce-labs-backpack");
    private static readonly By BackpackItemClassBy = By.XPath("//a[@Id='item_4_title_link']/div");

    public ProductsPage(IWebDriver driver) : base(driver)
    {
        HeaderPage = new HeaderPage(Driver);
    }

    protected override string GetEndpoint() => END_POINT;
    public override bool IsPageOpened() => TitleClass.Text.Trim().Equals("Products");

    public bool IsAddedToCart() => BackpackRemoveButton.Displayed;
    public bool IsRemovedFromCart() => BackpackAddButton.Displayed;
    public void ClickBackpackAddButton() => BackpackAddButton.Click();
    public void ClickBackpackRemoveButton() => BackpackRemoveButton.Click();

    public IWebElement BackpackAddButton => WaitsHelper.WaitForExists(BackpackAddButtonBy);
    public IWebElement BackpackRemoveButton => WaitsHelper.WaitForExists(BackpackRemoveButtonBy);
    public IWebElement BackpackItemClass => WaitsHelper.WaitForExists(BackpackItemClassBy);
}