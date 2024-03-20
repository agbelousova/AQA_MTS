namespace SaucedemoBDD.Steps;

[Binding]
public class UserStepDefs
{
    [Given(@"the user is logged in")]
    public void GivenTheUserIsLoggedIn()
    {
        ScenarioContext.StepIsPending();
    }

    [When(@"Filled in the user's data FIRSTNAME ""(.*)"", LASTNAME ""(.*)""")]
    public void WhenFilledInTheUsersDataFirstnamelastname(string testFIRSTNAME, string testLASTNAME)
    {
        ScenarioContext.StepIsPending();
    }
}