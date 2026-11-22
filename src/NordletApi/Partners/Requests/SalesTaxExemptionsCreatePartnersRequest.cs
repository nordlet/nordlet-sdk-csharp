using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SalesTaxExemptionsCreatePartnersRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("state")]
    public required SalesTaxExemptionsCreatePartnersRequestState State { get; set; }

    [JsonPropertyName("reasons")]
    public IEnumerable<SalesTaxExemptionsCreatePartnersRequestReasonsItem> Reasons { get; set; } =
        new List<SalesTaxExemptionsCreatePartnersRequestReasonsItem>();

    [JsonPropertyName("otherReason")]
    public string? OtherReason { get; set; }

    [JsonPropertyName("reasonDetail")]
    public string? ReasonDetail { get; set; }

    [JsonPropertyName("businessType")]
    public required SalesTaxExemptionsCreatePartnersRequestBusinessType BusinessType { get; set; }

    [JsonPropertyName("otherBusinessType")]
    public string? OtherBusinessType { get; set; }

    [JsonPropertyName("idNumber")]
    public required string IdNumber { get; set; }

    [JsonPropertyName("idIssuedBy")]
    public required string IdIssuedBy { get; set; }

    [JsonPropertyName("singlePurchaseReference")]
    public string? SinglePurchaseReference { get; set; }

    [JsonPropertyName("signedBy")]
    public string? SignedBy { get; set; }

    [JsonPropertyName("signerTitle")]
    public string? SignerTitle { get; set; }

    [JsonPropertyName("signedOn")]
    public DateOnly? SignedOn { get; set; }

    [JsonPropertyName("receivedOn")]
    public required DateOnly ReceivedOn { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
