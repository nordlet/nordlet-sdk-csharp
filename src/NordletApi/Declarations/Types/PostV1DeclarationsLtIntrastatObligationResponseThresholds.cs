using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatObligationResponseThresholds : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("arrivalsReporting")]
    public required string ArrivalsReporting { get; set; }

    [JsonPropertyName("dispatchesReporting")]
    public required string DispatchesReporting { get; set; }

    [JsonPropertyName("arrivalsStatistical")]
    public required string ArrivalsStatistical { get; set; }

    [JsonPropertyName("dispatchesStatistical")]
    public required string DispatchesStatistical { get; set; }

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
