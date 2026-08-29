using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionMaintenanceCompleteRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("completedDate")]
    public required string CompletedDate { get; set; }

    [JsonPropertyName("downtimeHours")]
    public string? DowntimeHours { get; set; }

    [JsonPropertyName("cost")]
    public string? Cost { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
