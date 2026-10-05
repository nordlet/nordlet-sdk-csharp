using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LandedCostsCreateInventoryRequest
{
    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("method")]
    public LandedCostsCreateInventoryRequestMethod? Method { get; set; }

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
