using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseMembersItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("companyId")]
    public required string CompanyId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("baseCurrency")]
    public required string BaseCurrency { get; set; }

    [JsonPropertyName("ownershipPercent")]
    public required string OwnershipPercent { get; set; }

    [JsonPropertyName("method")]
    public required PostV1ConsolidationReportResponseMembersItemMethod Method { get; set; }

    [JsonPropertyName("fxFactor")]
    public required string FxFactor { get; set; }

    [JsonPropertyName("rateFrom")]
    public required string RateFrom { get; set; }

    [JsonPropertyName("rateTo")]
    public required string RateTo { get; set; }

    [JsonPropertyName("totalAssets")]
    public required string TotalAssets { get; set; }

    [JsonPropertyName("netEquity")]
    public required string NetEquity { get; set; }

    [JsonPropertyName("periodResult")]
    public required string PeriodResult { get; set; }

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
