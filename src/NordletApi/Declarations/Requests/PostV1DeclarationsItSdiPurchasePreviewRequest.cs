using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsItSdiPurchasePreviewRequest
{
    [JsonPropertyName("purchaseInvoiceId")]
    public required string PurchaseInvoiceId { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("tipoDocumento")]
    public PostV1DeclarationsItSdiPurchasePreviewRequestTipoDocumento? TipoDocumento { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
