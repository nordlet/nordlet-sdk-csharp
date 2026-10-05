using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PriceListsItemsSetCatalogRequest
{
    [JsonPropertyName("priceListId")]
    public required string PriceListId { get; set; }

    [JsonPropertyName("items")]
    public IEnumerable<PriceListsItemsSetCatalogRequestItemsItem> Items { get; set; } =
        new List<PriceListsItemsSetCatalogRequestItemsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
