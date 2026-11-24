using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeTsdAnnexesSetDeclarationsRequestAnnex6RelatedPartiesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// 6200: registry code of the related person
    /// </summary>
    [JsonPropertyName("registryCode")]
    public required string RegistryCode { get; set; }

    /// <summary>
    /// 6210
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// 6220: ISO 3166-1 alpha-2 country
    /// </summary>
    [JsonPropertyName("country")]
    public required string Country { get; set; }

    /// <summary>
    /// 6230: taxable amount
    /// </summary>
    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    /// <summary>
    /// 6240: 621 transfer price, 6211 transfer price with a party under TuMS § 52¹, 622 income not received or cost not incurred, 623 hybrid mismatch (TuMS §§ 54⁷, 54⁸), 624 market value on a transfer to a tonnage unit
    /// </summary>
    [JsonPropertyName("typeCode")]
    public required EeTsdAnnexesSetDeclarationsRequestAnnex6RelatedPartiesItemTypeCode TypeCode { get; set; }

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
