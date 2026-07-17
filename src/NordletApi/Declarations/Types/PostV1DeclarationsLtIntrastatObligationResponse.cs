using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatObligationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("isVatPayer")]
    public required bool IsVatPayer { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("thresholds")]
    public required PostV1DeclarationsLtIntrastatObligationResponseThresholds Thresholds { get; set; }

    [JsonPropertyName("arrivals")]
    public required PostV1DeclarationsLtIntrastatObligationResponseArrivals Arrivals { get; set; }

    [JsonPropertyName("dispatches")]
    public required PostV1DeclarationsLtIntrastatObligationResponseDispatches Dispatches { get; set; }

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
