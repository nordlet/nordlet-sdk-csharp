using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuSmeThresholdGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("isVatPayer")]
    public required bool IsVatPayer { get; set; }

    [JsonPropertyName("baseCurrency")]
    public required string BaseCurrency { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("threshold")]
    public EuSmeThresholdGetDeclarationsResponseThreshold? Threshold { get; set; }

    [JsonPropertyName("turnover")]
    public required EuSmeThresholdGetDeclarationsResponseTurnover Turnover { get; set; }

    [JsonPropertyName("precedingTurnover")]
    public required EuSmeThresholdGetDeclarationsResponsePrecedingTurnover PrecedingTurnover { get; set; }

    [JsonPropertyName("status")]
    public required EuSmeThresholdGetDeclarationsResponseStatus Status { get; set; }

    [JsonPropertyName("headroomAmount")]
    public string? HeadroomAmount { get; set; }

    [JsonPropertyName("intraEu")]
    public EuSmeThresholdGetDeclarationsResponseIntraEu? IntraEu { get; set; }

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
