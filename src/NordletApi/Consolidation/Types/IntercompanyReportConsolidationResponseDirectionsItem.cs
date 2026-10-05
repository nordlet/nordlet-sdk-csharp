using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record IntercompanyReportConsolidationResponseDirectionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sellerCompanyId")]
    public required string SellerCompanyId { get; set; }

    [JsonPropertyName("sellerName")]
    public required string SellerName { get; set; }

    [JsonPropertyName("buyerCompanyId")]
    public required string BuyerCompanyId { get; set; }

    [JsonPropertyName("buyerName")]
    public required string BuyerName { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<IntercompanyReportConsolidationResponseDirectionsItemDocumentsItem> Documents { get; set; } =
        new List<IntercompanyReportConsolidationResponseDirectionsItemDocumentsItem>();

    [JsonPropertyName("unmatchedPurchases")]
    public IEnumerable<IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItem> UnmatchedPurchases { get; set; } =
        new List<IntercompanyReportConsolidationResponseDirectionsItemUnmatchedPurchasesItem>();

    [JsonPropertyName("totals")]
    public IEnumerable<IntercompanyReportConsolidationResponseDirectionsItemTotalsItem> Totals { get; set; } =
        new List<IntercompanyReportConsolidationResponseDirectionsItemTotalsItem>();

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
