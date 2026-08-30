using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountSessionsListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
