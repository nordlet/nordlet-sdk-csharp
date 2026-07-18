using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuSmeThresholdGetResponse : IJsonOnDeserialized
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
    public PostV1DeclarationsEuSmeThresholdGetResponseThreshold? Threshold { get; set; }

    [JsonPropertyName("turnover")]
    public required PostV1DeclarationsEuSmeThresholdGetResponseTurnover Turnover { get; set; }

    [JsonPropertyName("precedingTurnover")]
    public required PostV1DeclarationsEuSmeThresholdGetResponsePrecedingTurnover PrecedingTurnover { get; set; }

    [JsonPropertyName("status")]
    public required PostV1DeclarationsEuSmeThresholdGetResponseStatus Status { get; set; }

    [JsonPropertyName("headroomAmount")]
    public string? HeadroomAmount { get; set; }

    [JsonPropertyName("intraEu")]
    public PostV1DeclarationsEuSmeThresholdGetResponseIntraEu? IntraEu { get; set; }

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
