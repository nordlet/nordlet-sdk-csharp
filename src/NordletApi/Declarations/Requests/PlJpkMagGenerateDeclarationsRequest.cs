using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlJpkMagGenerateDeclarationsRequest
{
    [JsonPropertyName("dateFrom")]
    public required DateOnly DateFrom { get; set; }

    [JsonPropertyName("dateTo")]
    public required DateOnly DateTo { get; set; }

    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
