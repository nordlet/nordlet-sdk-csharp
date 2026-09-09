using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountTableSettingsListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
