using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureSettingsRegenerateIntakeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("intakeEnabled")]
    public required bool IntakeEnabled { get; set; }

    [JsonPropertyName("captureAutoExtract")]
    public required bool CaptureAutoExtract { get; set; }

    [JsonPropertyName("intakeAddress")]
    public string? IntakeAddress { get; set; }

    [JsonPropertyName("ocrConfigured")]
    public required bool OcrConfigured { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
