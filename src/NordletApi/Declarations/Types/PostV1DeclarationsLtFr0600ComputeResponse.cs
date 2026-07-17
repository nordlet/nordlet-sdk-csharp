using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtFr0600ComputeResponse : IJsonOnDeserialized
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
    public IEnumerable<PostV1DeclarationsLtFr0600ComputeResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsLtFr0600ComputeResponseFieldsItem>();

    [JsonPropertyName("breakdown")]
    public IEnumerable<PostV1DeclarationsLtFr0600ComputeResponseBreakdownItem> Breakdown { get; set; } =
        new List<PostV1DeclarationsLtFr0600ComputeResponseBreakdownItem>();

    [JsonPropertyName("counts")]
    public required PostV1DeclarationsLtFr0600ComputeResponseCounts Counts { get; set; }

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
