using NLog;
using TestRailComplexApi.Models;
using System.Diagnostics;
using System.Net;

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
            Name = "WP Test",
            Announcement = "Some description!!!",
            ShowAnnouncement = true,
            SuiteMode = 1
        };

        var actualProject = ProjectService!.AddProject(_project);
        _project = actualProject.Result;
        
        // Блок проверок
        Assert.Multiple(() =>
        {
            Assert.That(actualProject.Result.Name, Is.EqualTo(_project.Name));
            Assert.That(actualProject.Result.Announcement, Is.EqualTo(_project.Announcement));
            Assert.That(actualProject.Result.SuiteMode, Is.EqualTo(_project.SuiteMode));
        });
        
        _logger.Info(_project.ToString);
    }
    
    [Test]
    [Order(2)]
    public void AddMilestoneTest()
    {
        _milestone = new Milestone
        {
            Name = "Milestone Test 1",
            Description = "Milestone Description"
        };
        
        var actualMilestone = MilestoneService!.AddMilestone(_milestone, _project.Id.ToString());

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
            Name = "Update",
            Description = "Description, Update",
            IsCompleted = true
        };

        var actualMilestone_upp = MilestoneService!.UpdateMilestone(milestone_upp, _milestone.Id.ToString());
        _milestone = actualMilestone_upp.Result;
        _logger.Info(_milestone.ToString());
        
        Assert.Multiple(() =>
        {
            
            Assert.That(actualMilestone_upp.Result.Name, Is.EqualTo(_milestone.Name));
            Assert.That(actualMilestone_upp.Result.Description, Is.EqualTo(_milestone.Description));
        });
    }
    
    [Test]
    [Order(4)]
    public void GetMilestonesTest()
    {
        var milestones = MilestoneService!.GetMilestones(_project.Id.ToString()).Result;
        
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
    
    [Test]
    [Order(6)]
    public void DeleteProjectTest()
    {
        Debug.Assert(ProjectService != null, nameof(ProjectService) + " != null");
        _logger.Info(ProjectService.DeleteProject(_project.Id.ToString()));
    }
}