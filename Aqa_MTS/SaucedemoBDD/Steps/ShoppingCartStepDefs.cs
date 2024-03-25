using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using SaucedemoCore.Pages;
using NUnit.Framework;
using SaucedemoCore.Pages.CheckoutPages;
 
 namespace SaucedemoBDD.Steps;

[Binding]
public class ShoppingCartStepDefs : BaseSteps
{
    private ShoppingCartSteps _shoppingCartSteps;
    private readonly ProductsPage _productsPage;
    private readonly CheckoutThirdPage _checkoutThirdPage;

    public ShoppingCartStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _shoppingCartSteps = new ShoppingCartSteps(Driver);
        _productsPage = new ProductsPage(Driver);
        _checkoutThirdPage = new CheckoutThirdPage(Driver);
    }
    
    [Given("The user has opened the product catalog page")]
    public void IsProductCatalogPage()
    {
        _productsPage.IsPageOpened();
    }

    [Given(@"The shopping cart is empty")]
    public void IsShoppingCartEmpty()
    {
        _shoppingCartSteps.IsEmptyCart();
    }

    [When("The user added one item to the shopping cart")]
    public void AddedOneItemToShoppingCart()
    {
        _shoppingCartSteps.AddItemToCart();
    }

    [Then("Order is completed")]
    public void IsOrderCompleted()
    {
        Assert.Multiple(() =>
        {
            Assert.That(_checkoutThirdPage.IsPageOpened);
            Assert.That(_shoppingCartSteps.IsOrderCompleted);
        });
    }

    [When(@"The user deleted the product")]
    public void DeletedProduct()
    {
        _shoppingCartSteps.RemoveItemFromCart();
    }

    [Then(@"The product has been successfully deleted")]
    public void IsProductSuccessfullyDeleted()
    {
        Assert.That(_productsPage.IsRemovedFromCart());
    }
}