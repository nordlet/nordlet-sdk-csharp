using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesReceiptsCreateRequest
{
    [JsonPropertyName("orderId")]
    public required string OrderId { get; set; }

    [JsonPropertyName("receiptDate")]
    public required string ReceiptDate { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1PurchasesReceiptsCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1PurchasesReceiptsCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
