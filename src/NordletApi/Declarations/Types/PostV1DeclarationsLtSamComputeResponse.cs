using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtSamComputeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("insuredCount")]
    public required long InsuredCount { get; set; }

    [JsonPropertyName("insuredIncomeTotal")]
    public required string InsuredIncomeTotal { get; set; }

    [JsonPropertyName("contributionsTotal")]
    public required string ContributionsTotal { get; set; }

    [JsonPropertyName("persons")]
    public IEnumerable<PostV1DeclarationsLtSamComputeResponsePersonsItem> Persons { get; set; } =
        new List<PostV1DeclarationsLtSamComputeResponsePersonsItem>();

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
