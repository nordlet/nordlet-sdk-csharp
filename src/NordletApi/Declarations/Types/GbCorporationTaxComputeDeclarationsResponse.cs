using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbCorporationTaxComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("days")]
    public required double Days { get; set; }

    [JsonPropertyName("taxableTotalProfits")]
    public required string TaxableTotalProfits { get; set; }

    [JsonPropertyName("augmentedProfits")]
    public required string AugmentedProfits { get; set; }

    [JsonPropertyName("parts")]
    public IEnumerable<GbCorporationTaxComputeDeclarationsResponsePartsItem> Parts { get; set; } =
        new List<GbCorporationTaxComputeDeclarationsResponsePartsItem>();

    [JsonPropertyName("marginalRelief")]
    public required string MarginalRelief { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

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
