using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface IMilestoneService
{
    Task<Milestones> GetMilestones(string projectId);
    Task<Milestone> AddMilestone(Milestone milestone);
    Task<Milestone> UpdateMilestone(Milestone milestone);
    HttpStatusCode DeleteMilestone(string milestoneId);
}