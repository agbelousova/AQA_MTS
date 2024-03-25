using NUnit.Framework;
using SaucedemoCore.Core;
using SaucedemoCore.Steps;
using SaucedemoCore.Helpers.Configuration;
using SaucedemoCore.Pages;
using BaseSteps = SaucedemoBDD.Steps.BaseSteps;

namespace SaucedemoBDD;

[Binding]
public class UserStepDefs : BaseSteps
{
    private UserSteps _userSteps;
    private LoginPage _loginPage;
    private ProductsPage _productsPage;
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

    [Given(@"The user logged ""(.*)"" with password ""(.*)"" logged in ""(.*)""")]
    public void GivenTheUserLoggedWithPasswordLoggedIn(string username, string password, string flag)
    {
        if (flag == "false")
            _userSteps.IncorrectLogin(username, password);
        else
            _userSteps.SuccessfullLogin(username, password);
    }
}