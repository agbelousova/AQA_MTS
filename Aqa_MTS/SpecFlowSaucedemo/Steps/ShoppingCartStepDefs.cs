namespace SaucedemoBDD.Steps;

[Binding]
public class ShoppingCartStepDefs
{
    [Given(@"The user has opened the product catalog page")]
    public void GivenTheUserHasOpenedTheProductCatalogPage()
    {
        ScenarioContext.StepIsPending();
    }

    [Given(@"The shopping cart is empty")]
    public void GivenTheShoppingCartIsEmpty()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"The user added one item to the shopping cart")]
    public void WhenTheUserAddedOneItemToTheShoppingCart()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"The order is completed")]
    public void ThenTheOrderIsCompleted()
    {
        ScenarioContext.StepIsPending();
    }
}