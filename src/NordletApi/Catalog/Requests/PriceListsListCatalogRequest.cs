using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PriceListsListCatalogRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
