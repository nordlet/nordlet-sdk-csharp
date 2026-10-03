using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1OfficersListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
