using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SessionsRevokeOthersAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
