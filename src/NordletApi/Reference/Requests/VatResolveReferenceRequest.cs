using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatResolveReferenceRequest
{
    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("customerCountryCode")]
    public string? CustomerCountryCode { get; set; }

    [JsonPropertyName("customerIsBusiness")]
    public bool? CustomerIsBusiness { get; set; }

    [JsonPropertyName("supplyType")]
    public VatResolveReferenceRequestSupplyType? SupplyType { get; set; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    [JsonPropertyName("belowDistanceSalesThreshold")]
    public bool? BelowDistanceSalesThreshold { get; set; }

    [JsonPropertyName("facilitatedByMarketplace")]
    public bool? FacilitatedByMarketplace { get; set; }

    [JsonPropertyName("actingAsMarketplace")]
    public bool? ActingAsMarketplace { get; set; }

    [JsonPropertyName("sellerEstablishedInEu")]
    public bool? SellerEstablishedInEu { get; set; }

    [JsonPropertyName("importedConsignmentValueEur")]
    public string? ImportedConsignmentValueEur { get; set; }

    [JsonPropertyName("serviceKind")]
    public VatResolveReferenceRequestServiceKind? ServiceKind { get; set; }

    [JsonPropertyName("serviceCountryCode")]
    public string? ServiceCountryCode { get; set; }

    [JsonPropertyName("underlyingSupplierGaveVatNumber")]
    public bool? UnderlyingSupplierGaveVatNumber { get; set; }

    [JsonPropertyName("underlyingSupplierChargesVat")]
    public bool? UnderlyingSupplierChargesVat { get; set; }

    [JsonPropertyName("goodsKind")]
    public VatResolveReferenceRequestGoodsKind? GoodsKind { get; set; }

    [JsonPropertyName("goodsLocationCountryCode")]
    public string? GoodsLocationCountryCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
