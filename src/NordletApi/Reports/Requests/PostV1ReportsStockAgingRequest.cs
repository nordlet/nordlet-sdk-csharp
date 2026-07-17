using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsStockAgingRequest
{
    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
