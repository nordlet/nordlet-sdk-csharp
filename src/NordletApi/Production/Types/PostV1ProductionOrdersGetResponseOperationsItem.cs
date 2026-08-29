using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionOrdersGetResponseOperationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("routingOperationId")]
    public string? RoutingOperationId { get; set; }

    [JsonPropertyName("workCenterId")]
    public required string WorkCenterId { get; set; }

    [JsonPropertyName("sequence")]
    public required long Sequence { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("plannedMinutes")]
    public required string PlannedMinutes { get; set; }

    [JsonPropertyName("actualMinutes")]
    public string? ActualMinutes { get; set; }

    [JsonPropertyName("costPerHour")]
    public required string CostPerHour { get; set; }

    [JsonPropertyName("cost")]
    public string? Cost { get; set; }

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
