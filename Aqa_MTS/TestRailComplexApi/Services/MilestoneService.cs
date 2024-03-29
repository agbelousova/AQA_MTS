using System.Net;
using RestSharp;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public class MilestoneService : IMilestoneService, IDisposable
{
    private readonly RestClientExtended _client;
    
    public MilestoneService(RestClientExtended client)
    {
        _client = client;
    }
    
    public Task<Milestones> GetMilestones(string projectId)
    {
        var request = new RestRequest("index.php?/api/v2/get_milestones/{project_id}")
            .AddUrlSegment("project_id", projectId);

        var melistones = _client.ExecuteAsync<Milestones>(request); 
        return melistones;
    }

    public Task<Milestone> AddMilestone(Milestone milestone)
    {
        var request = new RestRequest("index.php?/api/v2/add_milestone/{project_id}", Method.Post)
            .AddUrlSegment("project_id", milestone.IdProject)
            .AddJsonBody(milestone);
        
        return _client.ExecuteAsync<Milestone>(request);
    }

    public Task<Milestone> UpdateMilestone(Milestone milestone)
    {
        var request = new RestRequest("index.php?/api/v2/update_milestone/{milestone_id}", Method.Post)
            .AddUrlSegment("milestone_id", milestone.Id)
            .AddJsonBody(milestone);
        
        return _client.ExecuteAsync<Milestone>(request);
    }

    public HttpStatusCode DeleteMilestone(string milestoneId)
    {
        var request = new RestRequest("index.php?/api/v2/delete_milestone/{milestone_id}", Method.Post)
            .AddUrlSegment("milestone_id", milestoneId)
            .AddJsonBody("{}");
        
        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}