using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ApiKeysListAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
