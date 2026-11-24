using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;
using OneOf;

namespace NordletApi;

[Serializable]
public record InvoicesUpdateSalesRequestLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("quantity")]
    public OneOf<double, string>? Quantity { get; set; }

    [JsonPropertyName("unitPriceExclVat")]
    public string? UnitPriceExclVat { get; set; }

    [JsonPropertyName("unitPriceInclVat")]
    public string? UnitPriceInclVat { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("vatClassifierCode")]
    public string? VatClassifierCode { get; set; }

    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("recognition")]
    public InvoicesUpdateSalesRequestLinesItemRecognition? Recognition { get; set; }

    /// <summary>
    /// A fixed asset sold on this line: the line net is booked to the assets.disposalProceeds posting rule account and `assets/assets/dispose` takes the proceeds from the issued invoice. Only on an invoice (422), only for an asset that is not disposed, and not with revenue recognition over time.
    /// </summary>
    [JsonPropertyName("assetId")]
    public string? AssetId { get; set; }

    [JsonPropertyName("vatExemptionBasis")]
    public string? VatExemptionBasis { get; set; }

    /// <summary>
    /// The revenue account the line is credited to at issue, a postable account of the company's chart (422 otherwise); without it the operation type's income account, else the item's sale account, else the services revenue posting rule account for a service item or a line without an item and the products revenue posting rule account for a product item. A line that sells a fixed asset always goes to `assets.disposalProceeds`.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; set; }

    [JsonPropertyName("standaloneSellingPrice")]
    public string? StandaloneSellingPrice { get; set; }

    [JsonPropertyName("refundEstimatePercent")]
    public string? RefundEstimatePercent { get; set; }

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
