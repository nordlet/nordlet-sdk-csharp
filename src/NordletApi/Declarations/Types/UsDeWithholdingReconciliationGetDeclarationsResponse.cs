using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeWithholdingReconciliationGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required double Year { get; set; }

    [JsonPropertyName("taxpayerId")]
    public string? TaxpayerId { get; set; }

    [JsonPropertyName("taxPeriodStarting")]
    public required string TaxPeriodStarting { get; set; }

    [JsonPropertyName("taxPeriodEnding")]
    public required string TaxPeriodEnding { get; set; }

    [JsonPropertyName("line1")]
    public required string Line1 { get; set; }

    [JsonPropertyName("line2")]
    public required double Line2 { get; set; }

    [JsonPropertyName("line3")]
    public required string Line3 { get; set; }

    [JsonPropertyName("line4")]
    public string? Line4 { get; set; }

    [JsonPropertyName("line5a")]
    public string? Line5A { get; set; }

    [JsonPropertyName("line5b")]
    public string? Line5B { get; set; }

    [JsonPropertyName("line6")]
    public string? Line6 { get; set; }

    [JsonPropertyName("worksheet")]
    public IEnumerable<UsDeWithholdingReconciliationGetDeclarationsResponseWorksheetItem> Worksheet { get; set; } =
        new List<UsDeWithholdingReconciliationGetDeclarationsResponseWorksheetItem>();

    [JsonPropertyName("totalTaxPaid")]
    public string? TotalTaxPaid { get; set; }

    [JsonPropertyName("totalTaxWithheld")]
    public required string TotalTaxWithheld { get; set; }

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
