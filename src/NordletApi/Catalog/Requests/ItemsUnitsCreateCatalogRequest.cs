using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItemsUnitsCreateCatalogRequest
{
    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("unitCode")]
    public required string UnitCode { get; set; }

    [JsonPropertyName("factor")]
    public required string Factor { get; set; }

    [JsonPropertyName("isDefaultSale")]
    public bool? IsDefaultSale { get; set; }

    [JsonPropertyName("isDefaultPurchase")]
    public bool? IsDefaultPurchase { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
