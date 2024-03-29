using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Cases
{
    [JsonPropertyName("offset")] public int Offset { get; set; }
    [JsonPropertyName("limit")] public int Limit { get; set; }
    [JsonPropertyName("size")] public int Size { get; set; }
    [JsonPropertyName("_links")] public Links Links { get; set; }
    [JsonPropertyName("cases")] public Case[] CaseList { get; set; }
}