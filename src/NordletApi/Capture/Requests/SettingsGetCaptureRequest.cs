using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsGetCaptureRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
