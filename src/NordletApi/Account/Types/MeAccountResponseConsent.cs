using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MeAccountResponseConsent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("termsVersion")]
    public string? TermsVersion { get; set; }

    [JsonPropertyName("termsAcceptedAt")]
    public DateTime? TermsAcceptedAt { get; set; }

    [JsonPropertyName("dpaVersion")]
    public string? DpaVersion { get; set; }

    [JsonPropertyName("dpaAcceptedAt")]
    public DateTime? DpaAcceptedAt { get; set; }

    [JsonPropertyName("currentTermsVersion")]
    public required string CurrentTermsVersion { get; set; }

    [JsonPropertyName("currentDpaVersion")]
    public required string CurrentDpaVersion { get; set; }

    [JsonPropertyName("required")]
    public required bool Required { get; set; }

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
