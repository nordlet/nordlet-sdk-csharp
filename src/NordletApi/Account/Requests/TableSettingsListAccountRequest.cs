using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TableSettingsListAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
