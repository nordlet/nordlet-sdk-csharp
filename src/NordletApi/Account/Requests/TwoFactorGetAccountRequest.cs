using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TwoFactorGetAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
