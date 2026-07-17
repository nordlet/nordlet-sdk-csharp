using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsStockAgingResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("itemName")]
    public required string ItemName { get; set; }

    [JsonPropertyName("warehouseId")]
    public required string WarehouseId { get; set; }

    [JsonPropertyName("d0to30Qty")]
    public required string D0To30Qty { get; set; }

    [JsonPropertyName("d0to30Value")]
    public required string D0To30Value { get; set; }

    [JsonPropertyName("d31to60Qty")]
    public required string D31To60Qty { get; set; }

    [JsonPropertyName("d31to60Value")]
    public required string D31To60Value { get; set; }

    [JsonPropertyName("d61to90Qty")]
    public required string D61To90Qty { get; set; }

    [JsonPropertyName("d61to90Value")]
    public required string D61To90Value { get; set; }

    [JsonPropertyName("over90Qty")]
    public required string Over90Qty { get; set; }

    [JsonPropertyName("over90Value")]
    public required string Over90Value { get; set; }

    [JsonPropertyName("totalQty")]
    public required string TotalQty { get; set; }

    [JsonPropertyName("totalValue")]
    public required string TotalValue { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
