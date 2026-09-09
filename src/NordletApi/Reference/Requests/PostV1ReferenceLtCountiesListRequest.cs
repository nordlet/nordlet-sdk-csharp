using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceLtCountiesListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
