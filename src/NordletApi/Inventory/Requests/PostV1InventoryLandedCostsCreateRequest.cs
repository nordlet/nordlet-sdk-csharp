using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventoryLandedCostsCreateRequest
{
    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("method")]
    public PostV1InventoryLandedCostsCreateRequestMethod? Method { get; set; }

    [JsonPropertyName("goodsReceiptId")]
    public string? GoodsReceiptId { get; set; }

    [JsonPropertyName("movementIds")]
    public IEnumerable<string>? MovementIds { get; set; }

    [JsonPropertyName("sourceInvoiceId")]
    public string? SourceInvoiceId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
