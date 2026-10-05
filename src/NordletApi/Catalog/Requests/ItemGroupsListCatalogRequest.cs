using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItemGroupsListCatalogRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
