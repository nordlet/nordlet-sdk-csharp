using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsGetInventoryRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
