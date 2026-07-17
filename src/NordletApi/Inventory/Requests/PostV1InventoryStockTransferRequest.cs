using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventoryStockTransferRequest
{
    [JsonPropertyName("fromWarehouseId")]
    public required string FromWarehouseId { get; set; }

    [JsonPropertyName("toWarehouseId")]
    public required string ToWarehouseId { get; set; }

    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
