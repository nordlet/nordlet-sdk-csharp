using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ReportConsolidationResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("presentationCurrency")]
    public required string PresentationCurrency { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("category")]
    public required ReportConsolidationResponseCategory Category { get; set; }

    [JsonPropertyName("statements")]
    public required ReportConsolidationResponseStatements Statements { get; set; }

    [JsonPropertyName("trialBalance")]
    public IEnumerable<ReportConsolidationResponseTrialBalanceItem> TrialBalance { get; set; } =
        new List<ReportConsolidationResponseTrialBalanceItem>();

    [JsonPropertyName("nonControllingInterest")]
    public required ReportConsolidationResponseNonControllingInterest NonControllingInterest { get; set; }

    [JsonPropertyName("equityMethod")]
    public required ReportConsolidationResponseEquityMethod EquityMethod { get; set; }

    [JsonPropertyName("members")]
    public IEnumerable<ReportConsolidationResponseMembersItem> Members { get; set; } =
        new List<ReportConsolidationResponseMembersItem>();

    [JsonPropertyName("eliminations")]
    public required ReportConsolidationResponseEliminations Eliminations { get; set; }

    [JsonPropertyName("cashFlow")]
    public required ReportConsolidationResponseCashFlow CashFlow { get; set; }

    [JsonPropertyName("intercompanyCandidates")]
    public IEnumerable<ReportConsolidationResponseIntercompanyCandidatesItem> IntercompanyCandidates { get; set; } =
        new List<ReportConsolidationResponseIntercompanyCandidatesItem>();

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
