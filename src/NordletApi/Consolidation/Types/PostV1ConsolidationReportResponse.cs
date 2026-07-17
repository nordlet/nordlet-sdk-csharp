using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("presentationCurrency")]
    public required string PresentationCurrency { get; set; }

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("category")]
    public required PostV1ConsolidationReportResponseCategory Category { get; set; }

    [JsonPropertyName("statements")]
    public required PostV1ConsolidationReportResponseStatements Statements { get; set; }

    [JsonPropertyName("trialBalance")]
    public IEnumerable<PostV1ConsolidationReportResponseTrialBalanceItem> TrialBalance { get; set; } =
        new List<PostV1ConsolidationReportResponseTrialBalanceItem>();

    [JsonPropertyName("nonControllingInterest")]
    public required PostV1ConsolidationReportResponseNonControllingInterest NonControllingInterest { get; set; }

    [JsonPropertyName("equityMethod")]
    public required PostV1ConsolidationReportResponseEquityMethod EquityMethod { get; set; }

    [JsonPropertyName("members")]
    public IEnumerable<PostV1ConsolidationReportResponseMembersItem> Members { get; set; } =
        new List<PostV1ConsolidationReportResponseMembersItem>();

    [JsonPropertyName("eliminations")]
    public required PostV1ConsolidationReportResponseEliminations Eliminations { get; set; }

    [JsonPropertyName("intercompanyCandidates")]
    public IEnumerable<PostV1ConsolidationReportResponseIntercompanyCandidatesItem> IntercompanyCandidates { get; set; } =
        new List<PostV1ConsolidationReportResponseIntercompanyCandidatesItem>();

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
