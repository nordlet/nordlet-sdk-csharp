using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesInvoicesMatchRequest
{
    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("priceTolerancePercent")]
    public string? PriceTolerancePercent { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
