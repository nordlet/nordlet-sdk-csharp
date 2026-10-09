using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsGetAssetsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
