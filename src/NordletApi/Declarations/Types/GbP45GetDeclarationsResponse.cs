using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbP45GetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("taxYear")]
    public required double TaxYear { get; set; }

    [JsonPropertyName("completedOn")]
    public required string CompletedOn { get; set; }

    [JsonPropertyName("employer")]
    public required GbP45GetDeclarationsResponseEmployer Employer { get; set; }

    [JsonPropertyName("employee")]
    public required GbP45GetDeclarationsResponseEmployee Employee { get; set; }

    [JsonPropertyName("studentLoanDeductionsToContinue")]
    public required bool StudentLoanDeductionsToContinue { get; set; }

    [JsonPropertyName("taxCode")]
    public required string TaxCode { get; set; }

    [JsonPropertyName("week1Month1")]
    public required bool Week1Month1 { get; set; }

    [JsonPropertyName("lastEntries")]
    public GbP45GetDeclarationsResponseLastEntries? LastEntries { get; set; }

    [JsonPropertyName("thisEmployment")]
    public GbP45GetDeclarationsResponseThisEmployment? ThisEmployment { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
