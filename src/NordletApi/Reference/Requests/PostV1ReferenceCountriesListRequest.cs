using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceCountriesListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
