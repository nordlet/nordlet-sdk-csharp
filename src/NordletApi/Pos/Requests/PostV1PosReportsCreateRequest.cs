using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PosReportsCreateRequest
{
    [JsonPropertyName("reportNumber")]
    public required string ReportNumber { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    [JsonPropertyName("vatLines")]
    public IEnumerable<PostV1PosReportsCreateRequestVatLinesItem> VatLines { get; set; } =
        new List<PostV1PosReportsCreateRequestVatLinesItem>();

    [JsonPropertyName("cashAmount")]
    public string? CashAmount { get; set; }

    [JsonPropertyName("cardAmount")]
    public string? CardAmount { get; set; }

    [JsonPropertyName("itemLines")]
    public IEnumerable<PostV1PosReportsCreateRequestItemLinesItem>? ItemLines { get; set; }

    [JsonPropertyName("cashAccountCode")]
    public string? CashAccountCode { get; set; }

    [JsonPropertyName("cardAccountCode")]
    public string? CardAccountCode { get; set; }

    [JsonPropertyName("revenueAccountCode")]
    public string? RevenueAccountCode { get; set; }

    [JsonPropertyName("vatAccountCode")]
    public string? VatAccountCode { get; set; }

    [JsonPropertyName("cogsAccountCode")]
    public string? CogsAccountCode { get; set; }

    [JsonPropertyName("inventoryAccountCode")]
    public string? InventoryAccountCode { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
