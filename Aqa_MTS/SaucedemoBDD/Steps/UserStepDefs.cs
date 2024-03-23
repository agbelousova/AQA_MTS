using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using SaucedemoCore.Helpers.Configuration;
using BaseSteps = SaucedemoBDD.Steps.BaseSteps;

namespace SaucedemoBDD;

[Binding]
public class UserStepDefs : BaseSteps
{
    private UserSteps _userSteps;

    public UserStepDefs(Browser browser, ScenarioContext scenarioContext) : base(browser, scenarioContext)
    {
        _userSteps = new UserSteps(Driver);
    }
    
    [Given("The user logged standard")]
    public void SuccessfullLogin()
    {
        _userSteps.SuccessfullLogin(Configurator.AppSettings.Username, Configurator.AppSettings.Password);
    }

    [When(@"Filled in the user's data FirstName ""(.*)"", LastName ""(.*)"" and ZipCode ""(.*)""")]
    public void FilledUsersData(string firstName, string lastName, string zipCode)
    {
        _userSteps.FillUserData(firstName, lastName, zipCode);
    }
}