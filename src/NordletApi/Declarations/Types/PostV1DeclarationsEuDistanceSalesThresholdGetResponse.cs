using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuDistanceSalesThresholdGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("thresholdEur")]
    public required string ThresholdEur { get; set; }

    [JsonPropertyName("homeCountryCode")]
    public required string HomeCountryCode { get; set; }

    [JsonPropertyName("currentYear")]
    public required PostV1DeclarationsEuDistanceSalesThresholdGetResponseCurrentYear CurrentYear { get; set; }

    [JsonPropertyName("precedingYear")]
    public required PostV1DeclarationsEuDistanceSalesThresholdGetResponsePrecedingYear PrecedingYear { get; set; }

    [JsonPropertyName("belowThreshold")]
    public required bool BelowThreshold { get; set; }

    [JsonPropertyName("headroomAmount")]
    public required string HeadroomAmount { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
