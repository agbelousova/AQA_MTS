using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface IMilestoneService
{
    Task<Milestones> GetMilestones(string projectId);
    Task<Milestone> AddMilestone(Milestone milestone, string project_id);
    Task<Milestone> UpdateMilestone(Milestone milestone, string milestone_id);
    HttpStatusCode DeleteMilestone(string milestoneId);
}