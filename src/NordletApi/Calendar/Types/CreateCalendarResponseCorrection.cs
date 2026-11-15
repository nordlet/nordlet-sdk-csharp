using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CreateCalendarResponseCorrection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public IEnumerable<CreateCalendarResponseCorrectionRequiredItem> Required { get; set; } =
        new List<CreateCalendarResponseCorrectionRequiredItem>();

    [JsonPropertyName("optional")]
    public IEnumerable<CreateCalendarResponseCorrectionOptionalItem> Optional { get; set; } =
        new List<CreateCalendarResponseCorrectionOptionalItem>();

    [JsonPropertyName("reasonCodes")]
    public IEnumerable<CreateCalendarResponseCorrectionReasonCodesItem> ReasonCodes { get; set; } =
        new List<CreateCalendarResponseCorrectionReasonCodesItem>();

    [JsonPropertyName("carry")]
    public required bool Carry { get; set; }

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
