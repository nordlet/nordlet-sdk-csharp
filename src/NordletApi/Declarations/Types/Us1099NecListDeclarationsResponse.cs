using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record Us1099NecListDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required double Year { get; set; }

    [JsonPropertyName("threshold")]
    public required string Threshold { get; set; }

    [JsonPropertyName("forms")]
    public IEnumerable<Us1099NecListDeclarationsResponseFormsItem> Forms { get; set; } =
        new List<Us1099NecListDeclarationsResponseFormsItem>();

    [JsonPropertyName("excluded")]
    public IEnumerable<Us1099NecListDeclarationsResponseExcludedItem> Excluded { get; set; } =
        new List<Us1099NecListDeclarationsResponseExcludedItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
