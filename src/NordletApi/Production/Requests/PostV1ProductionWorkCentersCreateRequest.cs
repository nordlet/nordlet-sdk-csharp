using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionWorkCentersCreateRequest
{
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("costPerHour")]
    public string? CostPerHour { get; set; }

    [JsonPropertyName("costAccountCode")]
    public string? CostAccountCode { get; set; }

    [JsonPropertyName("maintenanceIntervalDays")]
    public long? MaintenanceIntervalDays { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
