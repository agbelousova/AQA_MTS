using System.Text.Json.Serialization;

namespace TestRailComplexApi.Models;

public class Case
{
    [JsonPropertyName("created_by")] public int CreatedBy { get; set; }
    [JsonPropertyName("created_on")] public DateTime CreatedOn { get; set; }
    [JsonPropertyName("estimate")] public DateTime? Estimate { get; set; }
    [JsonPropertyName("estimate_forecast")] public DateTime EstimateForecast { get; set; }
    [JsonPropertyName("id")] public int Id { get; set; }
    [JsonPropertyName("milestone_id")] public int? MilestoneId { get; set; }
    [JsonPropertyName("priority_id")] public int PriorityId { get; set; }
    [JsonPropertyName("refs")] public string? Refs { get; set; }
    [JsonPropertyName("section_id")] public int SectionId { get; set; }
    [JsonPropertyName("suite_id")] public int SuiteId { get; set; }
    [JsonPropertyName("template_id")] public int TemplateId { get; set; }
    [JsonPropertyName("title")] public string? Title { get; set; }
    [JsonPropertyName("type_id")] public int TypeId { get; set; }
    [JsonPropertyName("display_order")] public int DisplayOrder { get; set; }
    [JsonPropertyName("is_deleted")] public int IsDeleted { get; set; }
    [JsonPropertyName("updated_by")] public int UpdatedBy { get; set; }
    [JsonPropertyName("updated_on")] public DateTime UpdatedOn { get; set; }
    [JsonPropertyName("custom_automation_type")] public int CustomAutomationType { get; set; }
    [JsonPropertyName("custom_preconds")] public string? CustomPreconds { get; set; }
    [JsonPropertyName("custom_steps")] public string? CustomSteps { get; set; }
    [JsonPropertyName("custom_expected")] public string? CustomExpected { get; set; }
    [JsonPropertyName("custom_steps_separated")] public string? CustomStepsSeparated { get; set; }
    [JsonPropertyName("custom_mission")] public string? CustomMission { get; set; }
    [JsonPropertyName("custom_goals")] public string? CustomGoals { get; set; }
}