using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MtFs7GenerateDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("boxes")]
    public IEnumerable<MtFs7GenerateDeclarationsResponseBoxesItem> Boxes { get; set; } =
        new List<MtFs7GenerateDeclarationsResponseBoxesItem>();

    [JsonPropertyName("leftToPayer")]
    public IEnumerable<string> LeftToPayer { get; set; } = new List<string>();

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    /// <summary>
    /// The working copy, base64
    /// </summary>
    [JsonPropertyName("pdf")]
    public required string Pdf { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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
