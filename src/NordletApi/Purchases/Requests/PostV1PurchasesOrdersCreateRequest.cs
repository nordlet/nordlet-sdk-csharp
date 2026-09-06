using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesOrdersCreateRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("orderNumber")]
    public string? OrderNumber { get; set; }

    [JsonPropertyName("orderDate")]
    public required string OrderDate { get; set; }

    [JsonPropertyName("expectedDate")]
    public string? ExpectedDate { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1PurchasesOrdersCreateRequestLinesItem> Lines { get; set; } =
        new List<PostV1PurchasesOrdersCreateRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
