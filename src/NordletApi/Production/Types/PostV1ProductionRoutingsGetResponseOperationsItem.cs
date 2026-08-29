using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProductionRoutingsGetResponseOperationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("sequence")]
    public required long Sequence { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("workCenterId")]
    public required string WorkCenterId { get; set; }

    [JsonPropertyName("setupMinutes")]
    public required string SetupMinutes { get; set; }

    [JsonPropertyName("runMinutesPerUnit")]
    public required string RunMinutesPerUnit { get; set; }

    [JsonPropertyName("qualityCheckName")]
    public string? QualityCheckName { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

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
