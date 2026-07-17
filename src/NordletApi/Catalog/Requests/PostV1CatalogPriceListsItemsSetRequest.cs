using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogPriceListsItemsSetRequest
{
    [JsonPropertyName("priceListId")]
    public required string PriceListId { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PostV1CatalogPriceListsItemsSetRequestItemsItem> Items { get; set; } =
        new List<PostV1CatalogPriceListsItemsSetRequestItemsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
