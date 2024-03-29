using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public record Group
{
    public string Password { get; init; } = string.Empty;
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("role")] public string Role { get; set; }
    [JsonPropertyName("role_id")] public int IdRole { get; set; }
}