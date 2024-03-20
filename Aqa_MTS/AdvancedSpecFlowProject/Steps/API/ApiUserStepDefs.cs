namespace AdvancedSpecFlowProject.Steps.API;

[Binding]
public class ApiUserStepDefs : BaseApiSteps
{
    [Given(@"send request with correct data")]
    public void GivenSendRequestWithCorrectData()
    {
        ScenarioContext.StepIsPending();
    }

    [Then(@"response status code is (.*)")]
    public void ThenResponseStatusCodeIs(int p0)
    {
        ScenarioContext.StepIsPending();
    }
}