using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsPlJpkMagGenerateRequest
{
    [JsonPropertyName("dateFrom")]
    public required string DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public required string DateTo { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
