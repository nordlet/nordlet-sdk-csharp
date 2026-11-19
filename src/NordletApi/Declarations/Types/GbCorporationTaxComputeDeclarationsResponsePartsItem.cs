using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbCorporationTaxComputeDeclarationsResponsePartsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("financialYear")]
    public required double FinancialYear { get; set; }

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    [JsonPropertyName("days")]
    public required double Days { get; set; }

    [JsonPropertyName("profits")]
    public required string Profits { get; set; }

    [JsonPropertyName("augmentedProfits")]
    public required string AugmentedProfits { get; set; }

    [JsonPropertyName("lowerLimit")]
    public string? LowerLimit { get; set; }

    [JsonPropertyName("upperLimit")]
    public string? UpperLimit { get; set; }

    [JsonPropertyName("rate")]
    public required GbCorporationTaxComputeDeclarationsResponsePartsItemRate Rate { get; set; }

    [JsonPropertyName("taxAtMainRate")]
    public required string TaxAtMainRate { get; set; }

    [JsonPropertyName("marginalRelief")]
    public required string MarginalRelief { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

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
