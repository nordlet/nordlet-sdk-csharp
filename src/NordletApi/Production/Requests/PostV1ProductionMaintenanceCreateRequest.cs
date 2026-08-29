using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionMaintenanceCreateRequest
{
    [JsonPropertyName("workCenterId")]
    public required string WorkCenterId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1ProductionMaintenanceCreateRequestType Type { get; set; }

    [JsonPropertyName("plannedDate")]
    public required string PlannedDate { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
