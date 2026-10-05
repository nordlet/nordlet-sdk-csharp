using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StockTakeInventoryRequest
{
    [JsonPropertyName("warehouseId")]
    public required string WarehouseId { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public string? ExpenseAccountCode { get; set; }

    [JsonPropertyName("inventoryAccountCode")]
    public string? InventoryAccountCode { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<StockTakeInventoryRequestLinesItem> Lines { get; set; } =
        new List<StockTakeInventoryRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
