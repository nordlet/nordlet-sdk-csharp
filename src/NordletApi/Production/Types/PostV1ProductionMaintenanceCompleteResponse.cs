using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionMaintenanceCompleteResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("workCenterId")]
    public required string WorkCenterId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1ProductionMaintenanceCompleteResponseType Type { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ProductionMaintenanceCompleteResponseStatus Status { get; set; }

    [JsonPropertyName("plannedDate")]
    public required string PlannedDate { get; set; }

    [JsonPropertyName("completedDate")]
    public string? CompletedDate { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("downtimeHours")]
    public string? DowntimeHours { get; set; }

    [JsonPropertyName("cost")]
    public string? Cost { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
