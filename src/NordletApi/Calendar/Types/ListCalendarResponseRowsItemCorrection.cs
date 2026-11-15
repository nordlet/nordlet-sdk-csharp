using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ListCalendarResponseRowsItemCorrection : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("required")]
    public IEnumerable<ListCalendarResponseRowsItemCorrectionRequiredItem> Required { get; set; } =
        new List<ListCalendarResponseRowsItemCorrectionRequiredItem>();

    [JsonPropertyName("optional")]
    public IEnumerable<ListCalendarResponseRowsItemCorrectionOptionalItem> Optional { get; set; } =
        new List<ListCalendarResponseRowsItemCorrectionOptionalItem>();

    [JsonPropertyName("reasonCodes")]
    public IEnumerable<ListCalendarResponseRowsItemCorrectionReasonCodesItem> ReasonCodes { get; set; } =
        new List<ListCalendarResponseRowsItemCorrectionReasonCodesItem>();

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
