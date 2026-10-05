using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItSdiPurchaseSendDeclarationsRequest
{
    [JsonPropertyName("purchaseInvoiceId")]
    public required string PurchaseInvoiceId { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("tipoDocumento")]
    public ItSdiPurchaseSendDeclarationsRequestTipoDocumento? TipoDocumento { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
