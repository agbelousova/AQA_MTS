using NLog;
using TestRailComplexApi.Models;
using System.Diagnostics;
using System.Net;

namespace TestRailComplexApi.Tests;

public class CaseTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project = null!;
    private Case _case = null!;
    private Section _section = null!;
    
    [Test]
    [Order(1)]
    public void AddProjectTest()
    {
        _project = new Project
        {
            Name = "WP Test 1",
            Announcement = "Some description!!!",
            ShowAnnouncement = true,
            SuiteMode = 1
        };

        var actualProject = ProjectService!.AddProject(_project);
        
        // Блок проверок
        Assert.Multiple(() =>
        {
            Assert.That(actualProject.Result.Name, Is.EqualTo(_project.Name));
            Assert.That(actualProject.Result.Announcement, Is.EqualTo(_project.Announcement));
            Assert.That(actualProject.Result.SuiteMode, Is.EqualTo(_project.SuiteMode));
        });

        _project = actualProject.Result;
        _logger.Info(_project.ToString);
    }

    [Test]
    [Order(2)]
    public void AddSectionTest()
    {
        var _section = new Section()
        {
            Name = "Section Test",
            Description = "Description Section"
        };
        
        var actualSection = SectionServices!.AddSection(_project.Id.ToString(),_section);
        
        Assert.Multiple(() =>
        {
            Assert.That(actualSection.Result.Name, Is.EqualTo(_section.Name));
            Assert.That(actualSection.Result.Description, Is.EqualTo(_section.Description));
        });

        _section = actualSection.Result;
        _logger.Info(_section.ToString);
    }

    [Test]
    [Order(3)]
    public void AddCaseTest()
    {
        var _case = new Case()
        {
            Title = "Title Case"
        };

        var caseNew = CaseService!.AddCase(_section.Id.ToString(), _case);
        
        _case = caseNew.Result;
        _logger.Info(_case.ToString());
        
        Assert.That(caseNew.Result.Title, Is.EqualTo(_case.Title));
    }
    
    [Test]
    [Order(4)]
    public void GetCaseTest()
    {
        var actualCase = CaseService?.GetCase(_case.Id.ToString());
        _logger.Info(actualCase.Result.ToString);
        
        Assert.Multiple(() =>
        {
            Assert.That(actualCase.Result.Title, Is.EqualTo(_case.Title));
            Assert.That(actualCase.Result.Id, Is.EqualTo(_case.Id));
            Assert.That(actualCase.Status.Equals(HttpStatusCode.OK));
        });
    }

    [Test]
    [Order(5)]
    public void UpdateCaseTest()
    {
        
        var caseUpdate = new Case
        {
            PriorityId = 2,
            Estimate = "Test Estimate"
        };

        var actualCase = CaseService!.UpdateCase(caseUpdate, _case.Id.ToString());
        _case = actualCase.Result;
        _logger.Info(_case.ToString());
    }

    [Test]
    [Order(6)]
    public void MoveCasesToSectionTest()
    {
        var actualCase =
            CaseService!.MoveCaseToSection(_section.Id.ToString());

        Assert.That(actualCase == HttpStatusCode.OK);
    }
    
    [Test]
    [Order(7)]
    public void DeleteCaseTest()
    {
        Debug.Assert(CaseService != null, nameof(CaseService) + " != null");
        _logger.Info(CaseService.DeleteCase(_case.Id.ToString()));
    }
}