using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TwoFactorSetupAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
