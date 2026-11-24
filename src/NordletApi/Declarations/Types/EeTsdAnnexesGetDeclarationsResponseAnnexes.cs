using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesGetDeclarationsResponseAnnexes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("annex4")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex4Item>? Annex4 { get; set; }

    [JsonPropertyName("annex5")]
    public IEnumerable<EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex5Item>? Annex5 { get; set; }

    [JsonPropertyName("annex6")]
    public EeTsdAnnexesGetDeclarationsResponseAnnexesAnnex6? Annex6 { get; set; }

    /// <summary>
    /// Added to code 114; negative when annex 5 or 6 gives back more than the annexes add
    /// </summary>
    [JsonPropertyName("incomeTax")]
    public required string IncomeTax { get; set; }

    /// <summary>
    /// Code 4180, added to code 115
    /// </summary>
    [JsonPropertyName("socialTax")]
    public required string SocialTax { get; set; }

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
