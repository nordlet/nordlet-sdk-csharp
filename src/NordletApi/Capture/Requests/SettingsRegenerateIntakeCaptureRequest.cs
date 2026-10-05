using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsRegenerateIntakeCaptureRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
