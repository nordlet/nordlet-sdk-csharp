using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsPlJpkMagGenerateResponseCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pz")]
    public required long Pz { get; set; }

    [JsonPropertyName("pw")]
    public required long Pw { get; set; }

    [JsonPropertyName("wz")]
    public required long Wz { get; set; }

    [JsonPropertyName("rw")]
    public required long Rw { get; set; }

    [JsonPropertyName("rows")]
    public required long Rows { get; set; }

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
