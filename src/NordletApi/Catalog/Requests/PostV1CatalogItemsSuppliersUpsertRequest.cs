using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsSuppliersUpsertRequest
{
    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("supplierCode")]
    public string? SupplierCode { get; set; }

    [JsonPropertyName("purchasePriceExclVat")]
    public string? PurchasePriceExclVat { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
