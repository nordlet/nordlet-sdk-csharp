using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UpdateCalendarResponseCorrection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public IEnumerable<UpdateCalendarResponseCorrectionRequiredItem> Required { get; set; } =
        new List<UpdateCalendarResponseCorrectionRequiredItem>();

    [JsonPropertyName("optional")]
    public IEnumerable<UpdateCalendarResponseCorrectionOptionalItem> Optional { get; set; } =
        new List<UpdateCalendarResponseCorrectionOptionalItem>();

    [JsonPropertyName("reasonCodes")]
    public IEnumerable<UpdateCalendarResponseCorrectionReasonCodesItem> ReasonCodes { get; set; } =
        new List<UpdateCalendarResponseCorrectionReasonCodesItem>();

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
