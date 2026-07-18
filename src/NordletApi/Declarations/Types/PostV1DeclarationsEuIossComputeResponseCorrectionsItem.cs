using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEuIossComputeResponseCorrectionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("periodYear")]
    public required long PeriodYear { get; set; }

    [JsonPropertyName("periodQuarter")]
    public long? PeriodQuarter { get; set; }

    [JsonPropertyName("periodMonth")]
    public long? PeriodMonth { get; set; }

    [JsonPropertyName("taxableAmount")]
    public required string TaxableAmount { get; set; }

    [JsonPropertyName("vatAmount")]
    public required string VatAmount { get; set; }

    [JsonPropertyName("documents")]
    public required long Documents { get; set; }

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
