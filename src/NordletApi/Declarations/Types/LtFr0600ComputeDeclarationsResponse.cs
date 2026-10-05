using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtFr0600ComputeDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("deductionPercent")]
    public required long DeductionPercent { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<LtFr0600ComputeDeclarationsResponseFieldsItem> Fields { get; set; } =
        new List<LtFr0600ComputeDeclarationsResponseFieldsItem>();

    [JsonPropertyName("breakdown")]
    public IEnumerable<LtFr0600ComputeDeclarationsResponseBreakdownItem> Breakdown { get; set; } =
        new List<LtFr0600ComputeDeclarationsResponseBreakdownItem>();

    [JsonPropertyName("counts")]
    public required LtFr0600ComputeDeclarationsResponseCounts Counts { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

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
