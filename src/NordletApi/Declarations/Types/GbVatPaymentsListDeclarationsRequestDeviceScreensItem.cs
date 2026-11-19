using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatPaymentsListDeclarationsRequestDeviceScreensItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("width")]
    public required long Width { get; set; }

    [JsonPropertyName("height")]
    public required long Height { get; set; }

    [JsonPropertyName("scalingFactor")]
    public required double ScalingFactor { get; set; }

    [JsonPropertyName("colourDepth")]
    public required long ColourDepth { get; set; }

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
