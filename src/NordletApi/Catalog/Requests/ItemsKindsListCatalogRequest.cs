using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItemsKindsListCatalogRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
