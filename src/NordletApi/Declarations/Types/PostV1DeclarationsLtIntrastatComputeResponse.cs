using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("flow")]
    public required PostV1DeclarationsLtIntrastatComputeResponseFlow Flow { get; set; }

    [JsonPropertyName("referencePeriod")]
    public required string ReferencePeriod { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("fileId")]
    public string? FileId { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1DeclarationsLtIntrastatComputeResponseRowsItem> Rows { get; set; } =
        new List<PostV1DeclarationsLtIntrastatComputeResponseRowsItem>();

    [JsonPropertyName("totals")]
    public required PostV1DeclarationsLtIntrastatComputeResponseTotals Totals { get; set; }

    [JsonPropertyName("counts")]
    public required PostV1DeclarationsLtIntrastatComputeResponseCounts Counts { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

    [JsonPropertyName("xml")]
    public required string Xml { get; set; }

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
