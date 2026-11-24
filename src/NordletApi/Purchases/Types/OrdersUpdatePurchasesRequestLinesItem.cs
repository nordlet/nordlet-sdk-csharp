using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;
using OneOf;

namespace NordletApi;

[Serializable]
public record OrdersUpdatePurchasesRequestLinesItem : IJsonOnDeserialized
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

    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; set; }

    [JsonPropertyName("deferralStartDate")]
    public DateOnly? DeferralStartDate { get; set; }

    [JsonPropertyName("deferralEndDate")]
    public DateOnly? DeferralEndDate { get; set; }

    [JsonPropertyName("lotNumber")]
    public string? LotNumber { get; set; }

    [JsonPropertyName("expiryDate")]
    public DateOnly? ExpiryDate { get; set; }

    /// <summary>
    /// The share of the purchase used for the company's taxable supplies, in whole percent rounded up: required on a VAT type that deducts the line's own share (CZ-D21-P, CZ-D12-P, the poměrný koeficient of § 75 odst. 3 ZDPH) and refused on any other
    /// </summary>
    [JsonPropertyName("deductiblePercent")]
    public long? DeductiblePercent { get; set; }

    /// <summary>
    /// The chassis numbers of the passenger cars bought on the line. A Hungarian company lists them on sheet 2665A-09 of the VAT return of the period when the line is an intra-Community acquisition or an import (Áfa tv. 4/A. számú melléklet II.)
    /// </summary>
    [JsonPropertyName("chassisNumbers")]
    public IEnumerable<string>? ChassisNumbers { get; set; }

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
