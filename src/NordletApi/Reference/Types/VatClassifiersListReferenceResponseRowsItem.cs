using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatClassifiersListReferenceResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("nameEn")]
    public string? NameEn { get; set; }

    [JsonPropertyName("ratePercent")]
    public string? RatePercent { get; set; }

    [JsonPropertyName("side")]
    public required VatClassifiersListReferenceResponseRowsItemSide Side { get; set; }

    [JsonPropertyName("scheme")]
    public VatClassifiersListReferenceResponseRowsItemScheme? Scheme { get; set; }

    [JsonPropertyName("rateFromLine")]
    public required VatClassifiersListReferenceResponseRowsItemRateFromLine RateFromLine { get; set; }

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
