using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogPriceListsItemsDeleteRequest
{
    [JsonPropertyName("priceListId")]
    public required string PriceListId { get; set; }

    [JsonPropertyName("itemId")]
    public required string ItemId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
