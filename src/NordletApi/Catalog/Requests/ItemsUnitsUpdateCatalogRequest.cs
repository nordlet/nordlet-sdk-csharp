using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItemsUnitsUpdateCatalogRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("factor")]
    public string? Factor { get; set; }

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
