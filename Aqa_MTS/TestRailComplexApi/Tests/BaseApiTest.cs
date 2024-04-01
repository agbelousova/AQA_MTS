using NLog;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Models;
using TestRailComplexApi.Services;

namespace TestRailComplexApi.Tests;

public class BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    protected ProjectService? ProjectService;
    protected MilestoneService? MilestoneService;
    protected CaseService? CaseService;
    protected SectionServices? SectionServices;
    
    [OneTimeSetUp]
    public void SetUpApi()
    {
        var restClient = new RestClientExtended();
        ProjectService = new ProjectService(restClient);
        MilestoneService = new MilestoneService(restClient);
        CaseService = new CaseService(restClient);
        SectionServices = new SectionServices(restClient);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        ProjectService?.Dispose();
        MilestoneService?.Dispose();
        CaseService?.Dispose();
        SectionServices?.Dispose();
    }
}