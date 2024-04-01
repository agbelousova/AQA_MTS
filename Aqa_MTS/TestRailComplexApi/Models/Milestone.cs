using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Milestone
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string? Name { get; init; } 
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("project_id")] public int IdProject { get; set; }
    /*
    [JsonPropertyName("start_on")] public int? StartOn { get; set; }
    [JsonPropertyName("started_on")] public int StartedOn { get; set; }
    [JsonPropertyName("is_started")] public bool IsStarted { get; set; }
    [JsonPropertyName("due_on")] public int? DueOn { get; init; }
    [JsonPropertyName("completed_on")] public int? CompletedOn { get; set; }
    [JsonPropertyName("parent_id")] public int? IdParent { get; set; }
    [JsonPropertyName("refs")] public string? Refs { get; set; }
    [JsonPropertyName("url")] public string? Url { get; set; }
    [JsonPropertyName("milestones")] public List<Milestone> Milestones { get; set; } = new();
    */
}