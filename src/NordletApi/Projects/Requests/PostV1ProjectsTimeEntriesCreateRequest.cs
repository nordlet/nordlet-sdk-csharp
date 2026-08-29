using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProjectsTimeEntriesCreateRequest
{
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("hours")]
    public required string Hours { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("billable")]
    public bool? Billable { get; set; }

    [JsonPropertyName("hourlyRate")]
    public string? HourlyRate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
