using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1HrLeaveBalancesSetRequest
{
    [JsonPropertyName("employeeId")]
    public required string EmployeeId { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("entitledDays")]
    public required string EntitledDays { get; set; }

    [JsonPropertyName("usedDays")]
    public string? UsedDays { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
