using NLog;
using TestRailComplexApi.Models;
using System.Diagnostics;
using System.Net;
using Bogus;
using TestRailComplexApi.Fakers;

namespace TestRailComplexApi.Tests;

public class CaseTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project;
    private Section _section;
    private Case _case;
    private static Faker<Project> _projectFaker = new ProjectFaker();
    private static Faker<Section> _sectionFaker = new SectionsFaker();
    private static Faker<Case> _caseFaker = new CaseFaker();

    [OneTimeSetUp]
    public void OneTimeSetUp()
    {
        _project = _projectFaker.Generate();

        _project = ProjectService!.AddProject(_project).Result;
        _logger.Info(_project.ToString());
        
        _section = _sectionFaker.Generate();

        _section = SectionServices!.AddSection(_project.Id.ToString(), _section).Result;
        _logger.Info(_section.ToString());
    }
    
    [Test]
    [Order(1)]
    public void AddCaseTest()
    {
        _case = _caseFaker.Generate();

        var caseNew = CaseService!.AddCase(_section.Id.ToString(), _case);

        _case = caseNew.Result;
        _logger.Info(_case.ToString());
        
        Assert.That(caseNew.Result.Title, Is.EqualTo(_case.Title));
    }

    [Test]
    [Order(2)]
    public void GetCaseTest()
    {
        var actualCase = CaseService?.GetCase(_case.Id.ToString());
        _logger.Info(actualCase.Result.ToString);

        Assert.Multiple(() =>
        {
            Assert.That(actualCase.Result.Title, Is.EqualTo(_case.Title));
            Assert.That(actualCase.Result.Id, Is.EqualTo(_case.Id));
        });
    }

    [Test]
    [Order(3)]
    public void UpdateCaseTest()
    {
        var caseUpdate = new Case
        {
            Title = "New Title",
            PriorityId = 1
        };

        var actualCase = CaseService!.UpdateCase(caseUpdate, _case.Id.ToString());
        _case = actualCase.Result;
        _logger.Info(_case.ToString());
        
        Assert.Multiple(() =>
        {
            Assert.That(actualCase.Result.Title, Is.EqualTo(_case.Title));
            Assert.That(actualCase.Result.Id, Is.EqualTo(_case.Id));
        });
    }

    [Test]
    [Order(4)]
    public void MoveCasesToSectionTest()
    {
        var actualSection = _sectionFaker.Generate();
        actualSection = SectionServices!.AddSection(_project.Id.ToString(), actualSection).Result;
        
        var actualCase =
            CaseService!.MoveCaseToSection(_section.Id.ToString(), actualSection.Id.ToString(), _case.Id.ToString());
        
        Assert.That(actualCase == HttpStatusCode.OK);
    }

    [Test]
    [Order(5)]
    public void DeleteCaseTest()
    {
        Debug.Assert(CaseService != null, nameof(CaseService) + " != null");
        _logger.Info(CaseService.DeleteCase(_case.Id.ToString()));
    }
    
    [OneTimeTearDown]
    public void OneTimeTearDown()
    {
        Debug.Assert(ProjectService != null, nameof(ProjectService) + " != null");
        _logger.Info(ProjectService.DeleteProject(_project.Id.ToString()));
    }
}