using NLog;
using TestRailComplexApi.Models;
using System.Diagnostics;
using System.Net;
using Bogus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using TestRailComplexApi.Fakers;

namespace TestRailComplexApi.Tests;

public class Task3Test : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project;
    private Milestone _milestone;
    private static Faker<Project> _projectFaker = new ProjectFaker();
    
    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _project = _projectFaker.Generate();

        _project = ProjectService!.AddProject(_project).Result;
        _logger.Info(_project.ToString());
    }

    [Test]
    public void AddMilestone()
    {
        JSchema schema = JSchema.Parse(File.ReadAllText(@"Resources/schema.json"));

        _milestone = new Milestone
        {
            IdProject = _project.Id,
            Name = "Milestone Test 1",
            Description = "Milestone Description"
        };
        
        var result = MilestoneService!.AddMilstoneForSchema(_project.Id.ToString(), _milestone);

        Assert.That(result.Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));

        Milestone responseBody = JsonConvert.DeserializeObject<Milestone>(result.Result.Content);

        _logger.Info($"Response: {result.Result.Content}");

        Assert.Multiple((() =>
        {
            Assert.That(responseBody.Name, Is.EqualTo(_milestone.Name));
            Assert.That(responseBody.Description, Is.EqualTo(_milestone.Description));
            Assert.That(JObject.Parse(result.Result.Content).IsValid(schema));
        }));
    }

    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Debug.Assert(ProjectService != null, nameof(ProjectService) + " != null");
        _logger.Info(ProjectService.DeleteProject(_project.Id.ToString()));
    }
}