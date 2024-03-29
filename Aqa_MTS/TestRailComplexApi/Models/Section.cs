using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Section
{
    [JsonPropertyName("depth")] public int Depth { get; set; }
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("display_order")] public int DisplayOrder { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("parent_id")] public int? ParentId { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("suite_id")] public int SuiteId { get; set; }
}