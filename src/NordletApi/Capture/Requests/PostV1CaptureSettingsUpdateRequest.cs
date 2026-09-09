using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureSettingsUpdateRequest
{
    [JsonPropertyName("intakeEnabled")]
    public bool? IntakeEnabled { get; set; }

    [JsonPropertyName("captureAutoExtract")]
    public bool? CaptureAutoExtract { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
