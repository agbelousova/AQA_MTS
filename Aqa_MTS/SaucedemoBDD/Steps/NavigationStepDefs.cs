using SaucedemoCore.Core;
using SaucedemoCore.Steps;

namespace SaucedemoBDD.Steps;

[Binding]
public class NavigationStepDefs : BaseSteps
{
    private NavigationSteps _navigationSteps;

    public NavigationStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _navigationSteps = new NavigationSteps(Driver);
    }
    
    [When("Went to the shopping cart")]
    public void GoToShoppingCart()
    {
        _navigationSteps.GoToShoppingCart();
    }

    [When("Went to check")]
    public void GoToCheck()
    {
        _navigationSteps.GoToCheckout();
    }

    [When("Moved on to the second step of ordering")]
    public void GoToSecondStepOrdering()
    {
        _navigationSteps.GoToSecondStepCheckout();
    }

    [When("Moved on to the third step of ordering")]
    public void GoToThirdStepOrdering()
    {
        _navigationSteps.GoToThirdStepCheckout();
    }
}