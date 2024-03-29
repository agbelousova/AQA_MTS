﻿using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Milestones
{
    [JsonPropertyName("offset")] public int Offset { get; set; }
    [JsonPropertyName("limit")] public int Limit { get; set; }
    [JsonPropertyName("size")] public int Size { get; set; }
    [JsonPropertyName("_links")] public Links Links { get; set; }
    [JsonPropertyName("milestones")] public Milestone[] MilestoneList { get; set; }
}