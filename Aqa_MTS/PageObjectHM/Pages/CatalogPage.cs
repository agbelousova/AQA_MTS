using OpenQA.Selenium;
using PageObjectHM.Helpers;
using PageObjectHM.Helpers.Configuration;

namespace PageObjectHM.Pages
{
    public class CatalogPage : BasePage
    {
         private static string END_POINT = "inventory.html";

    private static readonly By InventoryContainerBy = By.Id("inventory_container");
    private static readonly By ShoppingCartBadgeBy = By.XPath("//span[@class='shopping_cart_badge']");
    private static readonly By AddToCartButtonBy = By.Id("add-to-cart-sauce-labs-backpack");
    private static readonly By RemoveToCartButtonBy = By.Id("remove-sauce-labs-backpack");
    public CatalogPage(IWebDriver driver, bool openPageByUrl) : base(driver, openPageByUrl)
    {
    }

    public CatalogPage(IWebDriver driver) : base(driver)
    {
    }

    public override bool IsPageOpened()
    {
        try
        {
            return InventoryContainer.Displayed;
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

    public IWebElement InventoryContainer => WaitsHelper.WaitForExists(InventoryContainerBy);
    public IWebElement ShoppingCartBadge => WaitsHelper.WaitForExists(ShoppingCartBadgeBy);
    public IWebElement AddProductButton => WaitsHelper.WaitForExists(AddToCartButtonBy);
    public IWebElement RemoveProductButton => WaitsHelper.WaitForExists(RemoveToCartButtonBy);
    
    public CatalogPage AddProduct()
    { 
        AddProductButton.Click();
        return new CatalogPage(Driver);
    }
    public CatalogPage RemoveProduct()
    {
        RemoveProductButton.Click();
        return new CatalogPage(Driver);
    }
    }
}