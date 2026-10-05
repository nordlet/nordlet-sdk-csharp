using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ReportConsolidationResponseStatements : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("category")]
    public required ReportConsolidationResponseStatementsCategory Category { get; set; }

    [JsonPropertyName("layout")]
    public required string Layout { get; set; }

    [JsonPropertyName("requiredStatements")]
    public IEnumerable<string> RequiredStatements { get; set; } = new List<string>();

    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("balanceSheet")]
    public required ReportConsolidationResponseStatementsBalanceSheet BalanceSheet { get; set; }

    [JsonPropertyName("profitLoss")]
    public required ReportConsolidationResponseStatementsProfitLoss ProfitLoss { get; set; }

    [JsonPropertyName("balanceSheetDetail")]
    public ReportConsolidationResponseStatementsBalanceSheetDetail? BalanceSheetDetail { get; set; }

    [JsonPropertyName("profitLossDetail")]
    public ReportConsolidationResponseStatementsProfitLossDetail? ProfitLossDetail { get; set; }

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
