using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsIeCt1GenerateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("periodStart")]
    public required string PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required string PeriodEnd { get; set; }

    [JsonPropertyName("taxRegNumber")]
    public required string TaxRegNumber { get; set; }

    [JsonPropertyName("ct1")]
    public required PostV1DeclarationsIeCt1GenerateResponseCt1 Ct1 { get; set; }

    [JsonPropertyName("accounts")]
    public PostV1DeclarationsIeCt1GenerateResponseAccounts? Accounts { get; set; }

    [JsonPropertyName("accountsBlocking")]
    public IEnumerable<string> AccountsBlocking { get; set; } = new List<string>();

    [JsonPropertyName("ixbrlMandatory")]
    public required bool IxbrlMandatory { get; set; }

    [JsonPropertyName("criteria")]
    public required PostV1DeclarationsIeCt1GenerateResponseCriteria Criteria { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1DeclarationsIeCt1GenerateResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsIeCt1GenerateResponseFieldsItem>();

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
