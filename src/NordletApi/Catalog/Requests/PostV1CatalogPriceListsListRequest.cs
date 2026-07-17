using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogPriceListsListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
