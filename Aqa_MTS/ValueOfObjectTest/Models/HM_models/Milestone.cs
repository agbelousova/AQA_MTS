using System.Text.Json.Serialization;

namespace ValueOfObjectTest.Models.HM_models;

public class Milestone
{
    [JsonPropertyName("completed_on")] public DateTime CompletedOn { get; set; }
    [JsonPropertyName("description")] public string Description { get; set; }
    [JsonPropertyName("due_on")] public DateTime DueOn { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("is_started")] public bool IsStarted { get; set; }
    [JsonPropertyName("milestones")] public Milestone[] Milestones { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("parent_id")] public int IdParent { get; set; }
    [JsonPropertyName("project_id")] public int IdProject { get; set; }
    [JsonPropertyName("refs")] public string Refs { get; set; }
    [JsonPropertyName("start_on")] public DateTime StartOn { get; set; }
    [JsonPropertyName("started_on")] public DateTime StartedOn { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; }
}