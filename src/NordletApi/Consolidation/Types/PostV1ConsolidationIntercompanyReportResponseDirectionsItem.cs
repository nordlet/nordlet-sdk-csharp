using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationIntercompanyReportResponseDirectionsItem : IJsonOnDeserialized
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
    public IEnumerable<PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItem> Documents { get; set; } =
        new List<PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItem>();

    [JsonPropertyName("unmatchedPurchases")]
    public IEnumerable<PostV1ConsolidationIntercompanyReportResponseDirectionsItemUnmatchedPurchasesItem> UnmatchedPurchases { get; set; } =
        new List<PostV1ConsolidationIntercompanyReportResponseDirectionsItemUnmatchedPurchasesItem>();

    [JsonPropertyName("totals")]
    public IEnumerable<PostV1ConsolidationIntercompanyReportResponseDirectionsItemTotalsItem> Totals { get; set; } =
        new List<PostV1ConsolidationIntercompanyReportResponseDirectionsItemTotalsItem>();

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
