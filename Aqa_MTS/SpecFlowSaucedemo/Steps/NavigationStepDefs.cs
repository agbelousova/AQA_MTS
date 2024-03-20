namespace SaucedemoBDD.Steps;

[Binding]
public class NavigationStepDefs
{
    [When(@"Went to the shopping cart")]
    public void WhenWentToTheShoppingCart()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"Moved on to checkout")]
    public void WhenMovedOnToCheckout()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"Moved on to the second step of ordering")]
    public void WhenMovedOnToTheSecondStepOfOrdering()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"Moved on to the third step of ordering")]
    public void WhenMovedOnToTheThirdStepOfOrdering()
    {
        ScenarioContext.StepIsPending();
    }
}