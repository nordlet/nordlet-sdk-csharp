using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceVatResolveRequest
{
    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("customerCountryCode")]
    public string? CustomerCountryCode { get; set; }

    [JsonPropertyName("customerIsBusiness")]
    public bool? CustomerIsBusiness { get; set; }

    [JsonPropertyName("supplyType")]
    public PostV1ReferenceVatResolveRequestSupplyType? SupplyType { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

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

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
