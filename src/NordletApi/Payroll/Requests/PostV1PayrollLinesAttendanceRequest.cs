using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollLinesAttendanceRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("daysWorked")]
    public string? DaysWorked { get; set; }

    [JsonPropertyName("hoursWorked")]
    public string? HoursWorked { get; set; }

    [JsonPropertyName("registeredDays")]
    public string? RegisteredDays { get; set; }

    [JsonPropertyName("averageHourlyEarnings")]
    public string? AverageHourlyEarnings { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
