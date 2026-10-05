using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MaintenanceCreateProductionRequest
{
    [JsonPropertyName("workCenterId")]
    public required string WorkCenterId { get; set; }

    [JsonPropertyName("type")]
    public required MaintenanceCreateProductionRequestType Type { get; set; }

    [JsonPropertyName("plannedDate")]
    public required DateOnly PlannedDate { get; set; }

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
