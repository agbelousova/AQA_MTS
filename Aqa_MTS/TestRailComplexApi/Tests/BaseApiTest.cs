using NLog;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Services;

namespace TestRailComplexApi.Tests;

public class BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;
    protected MilestoneService? MilestoneService;
    protected CaseService? CaseService;
    
    [OneTimeSetUp]
    public void SetUpApi()
    {
        var restClient = new RestClientExtended();
        ProjectService = new ProjectService(restClient);
        MilestoneService = new MilestoneService(restClient);
        CaseService = new CaseService(restClient);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        ProjectService?.Dispose();
        MilestoneService?.Dispose();
        CaseService?.Dispose();
    }
}