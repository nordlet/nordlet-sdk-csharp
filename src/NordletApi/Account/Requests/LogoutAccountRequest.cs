using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LogoutAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
