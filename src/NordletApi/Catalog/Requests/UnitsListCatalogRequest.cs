using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UnitsListCatalogRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
