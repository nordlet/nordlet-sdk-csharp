using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventoryStockTakeRequest
{
    [JsonPropertyName("warehouseId")]
    public required string WarehouseId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public string? ExpenseAccountCode { get; set; }

    [JsonPropertyName("inventoryAccountCode")]
    public string? InventoryAccountCode { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1InventoryStockTakeRequestLinesItem> Lines { get; set; } =
        new List<PostV1InventoryStockTakeRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
