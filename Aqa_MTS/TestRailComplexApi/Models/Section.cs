using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Section
{
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("description")] public string? Description { get; set; }
    
    [JsonPropertyName("suite_id")] public int SuiteId { get; set; }
}