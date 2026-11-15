using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GetCalendarResponseCorrection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public IEnumerable<GetCalendarResponseCorrectionRequiredItem> Required { get; set; } =
        new List<GetCalendarResponseCorrectionRequiredItem>();

    [JsonPropertyName("optional")]
    public IEnumerable<GetCalendarResponseCorrectionOptionalItem> Optional { get; set; } =
        new List<GetCalendarResponseCorrectionOptionalItem>();

    [JsonPropertyName("reasonCodes")]
    public IEnumerable<GetCalendarResponseCorrectionReasonCodesItem> ReasonCodes { get; set; } =
        new List<GetCalendarResponseCorrectionReasonCodesItem>();

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
