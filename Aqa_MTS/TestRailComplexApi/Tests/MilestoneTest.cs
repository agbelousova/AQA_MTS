using NLog;
using TestRailComplexApi.Models;
using System.Diagnostics;

namespace TestRailComplexApi.Tests;

public class MilestoneTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Milestone _milestone = null!;
    private Project _project = null!;
    
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
    public void AddMilestoneTest()
    {
        _milestone = new Milestone
        {
            IdProject = _project.Id,
            Name = "Milestone Test 1",
            Description = "Milestone Description"
        };
        
        var actualMilestone = MilestoneService!.AddMilestone(_milestone);

        // Блок проверок
        Assert.Multiple(() =>
        {
            
            Assert.That(actualMilestone.Result.Name, Is.EqualTo(_milestone.Name));
            Assert.That(actualMilestone.Result.Description, Is.EqualTo(_milestone.Description));
        });

        _milestone = actualMilestone.Result;
        _logger.Info((actualMilestone.Result).ToString);
    }
    
    [Test]
    [Order(3)]
    public void UpdateMilestoneTest()
    {
        var milestone_upp = new Milestone
        {
            IdProject = _milestone.IdProject,
            Name = "Update",
            Description = "Description, Update",
            IsCompleted = true
        };

        var actualMilestone_upp = MilestoneService!.UpdateMilestone(milestone_upp);
        milestone_upp = actualMilestone_upp.Result;
        _logger.Info(milestone_upp.ToString());
    }
    
    [Test]
    [Order(4)]
    public void GetMilestonesTest()
    {
        var milestones = MilestoneService?.GetMilestones(_milestone.IdProject.ToString()).Result;
        _logger.Info(milestones.Size);
        foreach (var milestone in milestones.MilestoneList)
        {
            _logger.Info(milestone.ToString);
        }
    }
    
    [Test]
    [Order(5)]
    public void DeleteMilestoneTest()
    {
        Debug.Assert(MilestoneService != null, nameof(MilestoneService) + " != null");
        _logger.Info(MilestoneService.DeleteMilestone(_milestone.Id.ToString()));
    }
}