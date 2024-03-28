using System.Text.Json.Serialization;

namespace ValueOfObjectTest.Models.HM_models;

public class Project
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string Name { get; set; }
    [JsonPropertyName("announcement")] public string Announcement { get; set; }
    [JsonPropertyName("show_announcement")] public bool IsShowAnnouncement { get; set; }
    [JsonPropertyName("suite_mode")] public int SuiteMode { get; set; }
    [JsonPropertyName("completed_on")] public int CompleatedOn { get; set; }
    [JsonPropertyName("default_role")] public string DefaultRole { get; set; }
    [JsonPropertyName("default_role_id")] public int IdDefaultRole { get; set; }
    [JsonPropertyName("is_completed")] public bool IsCompleted { get; set; }
    [JsonPropertyName("url")] public string Url { get; set; }
    [JsonPropertyName("groups")] public Group[] Groups { get; set; }
    [JsonPropertyName("users")] public User[] Users { get; set; }

    public class Group
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("role")] public string Role { get; set; }
        [JsonPropertyName("role_id")] public int IdRole { get; set; }
    }

    public class User
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("global_role_id")] public int IdGlobalRole { get; set; }
        [JsonPropertyName("global_role")] public string GlobalRole { get; set; }
        [JsonPropertyName("project_role_id")] public int IdProjectRole { get; set; }
        [JsonPropertyName("project_role")] public string ProjectRole { get; set; }
    }
}