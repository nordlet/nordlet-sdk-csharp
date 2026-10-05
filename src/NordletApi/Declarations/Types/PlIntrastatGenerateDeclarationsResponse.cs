using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlIntrastatGenerateDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("flow")]
    public required PlIntrastatGenerateDeclarationsResponseFlow Flow { get; set; }

    [JsonPropertyName("referencePeriod")]
    public required string ReferencePeriod { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("nip")]
    public required string Nip { get; set; }

    [JsonPropertyName("companyName")]
    public required string CompanyName { get; set; }

    [JsonPropertyName("detailedThreshold")]
    public required bool DetailedThreshold { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PlIntrastatGenerateDeclarationsResponseRowsItem> Rows { get; set; } =
        new List<PlIntrastatGenerateDeclarationsResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required PlIntrastatGenerateDeclarationsResponseTotals Totals { get; set; }

    [JsonPropertyName("counts")]
    public required PlIntrastatGenerateDeclarationsResponseCounts Counts { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("source")]
    public required string Source { get; set; }

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
