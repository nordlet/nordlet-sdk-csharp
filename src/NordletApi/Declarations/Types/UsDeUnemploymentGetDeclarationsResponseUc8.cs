using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeUnemploymentGetDeclarationsResponseUc8 : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("reportingPeriod")]
    public required string ReportingPeriod { get; set; }

    [JsonPropertyName("accountNo")]
    public string? AccountNo { get; set; }

    [JsonPropertyName("federalIdNumber")]
    public string? FederalIdNumber { get; set; }

    [JsonPropertyName("taxRate")]
    public string? TaxRate { get; set; }

    [JsonPropertyName("line1")]
    public IEnumerable<double> Line1 { get; set; } = new List<double>();

    [JsonPropertyName("line2")]
    public required string Line2 { get; set; }

    [JsonPropertyName("line3")]
    public required string Line3 { get; set; }

    [JsonPropertyName("line4")]
    public required string Line4 { get; set; }

    [JsonPropertyName("line5")]
    public required string Line5 { get; set; }

    [JsonPropertyName("line6")]
    public string? Line6 { get; set; }

    [JsonPropertyName("line7")]
    public required string Line7 { get; set; }

    [JsonPropertyName("line8")]
    public string? Line8 { get; set; }

    [JsonPropertyName("line9")]
    public string? Line9 { get; set; }

    [JsonPropertyName("line10")]
    public required string Line10 { get; set; }

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
