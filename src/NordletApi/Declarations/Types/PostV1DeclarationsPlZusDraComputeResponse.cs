using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsPlZusDraComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("source")]
    public required string Source { get; set; }

    [JsonPropertyName("runStatus")]
    public string? RunStatus { get; set; }

    [JsonPropertyName("insuredCount")]
    public required long InsuredCount { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1DeclarationsPlZusDraComputeResponseRowsItem> Rows { get; set; } =
        new List<PostV1DeclarationsPlZusDraComputeResponseRowsItem>();

    [JsonPropertyName("socialTotal")]
    public required string SocialTotal { get; set; }

    [JsonPropertyName("healthTotal")]
    public required string HealthTotal { get; set; }

    [JsonPropertyName("fundsTotal")]
    public required string FundsTotal { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

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
