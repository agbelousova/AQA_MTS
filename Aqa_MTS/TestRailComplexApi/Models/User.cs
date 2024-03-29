using System.Text.Json.Serialization;
using TestRailComplexApi.Models.Enums;

namespace TestRailComplexApi.Models;

public record User
{
    public UserType UserType { get; set; }
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
    
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("global_role_id")] public int IdGlobalRole { get; set; }
    [JsonPropertyName("global_role")] public string GlobalRole { get; set; }
    [JsonPropertyName("project_role_id")] public int IdProjectRole { get; set; }
    [JsonPropertyName("project_role")] public string ProjectRole { get; set; }
}