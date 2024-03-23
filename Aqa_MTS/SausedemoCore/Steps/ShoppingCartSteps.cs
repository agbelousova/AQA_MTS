using OpenQA.Selenium;
using SaucedemoCore.Pages;
using SaucedemoCore.Pages.CheckoutPages;

namespace SaucedemoCore.Steps;

public class ShoppingCartSteps : BaseSteps
{
    private ShoppingCartPage _shoppingCartPage;
    private ProductsPage _productsPage;
    private CheckoutOnePage _checkoutOnePage;
    private CheckoutSecondPage _checkoutSecondPage;
    private CheckoutThirdPage _checkoutThirdPage;

    public ShoppingCartSteps(IWebDriver driver) : base(driver)
    {
        _shoppingCartPage = new ShoppingCartPage(Driver);
        _productsPage = new ProductsPage(Driver);
        _checkoutThirdPage = new CheckoutThirdPage(Driver);
    }

    public bool AddItemToCart()
    {
        _productsPage.ClickBackpackAddButton();
        return _productsPage.IsAddedToCart();
    }

    public bool RemoveItemFromCart()
    {
        _productsPage.ClickBackpackRemoveButton();
        return _productsPage.IsRemovedFromCart();
    }

    public bool IsOrderCompleted()
    {
        return _checkoutThirdPage.OrderCompletedText().Equals("Thank you for your order!");
    }

    public bool IsEmptyFinalShoppingCart()
    {
        return _checkoutSecondPage.FirstItemInFinalShoppingCartText().Equals(string.Empty);
    }

    public bool IsEmptyCart() => _productsPage.HeaderPage.EmptyCartText().Equals(string.Empty);

    public int GetCountItemInShoppingCart()
    {
        int count = 0;
        if (!IsEmptyCart())
        {
            int.TryParse(_productsPage.HeaderPage.CountInShoppingCartClass?.Text.Trim(), out count);
            return count;
        }
        return count;
    }
}