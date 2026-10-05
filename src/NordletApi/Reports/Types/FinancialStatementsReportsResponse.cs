using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FinancialStatementsReportsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("category")]
    public required FinancialStatementsReportsResponseCategory Category { get; set; }

    [JsonPropertyName("layout")]
    public required string Layout { get; set; }

    [JsonPropertyName("requiredStatements")]
    public IEnumerable<string> RequiredStatements { get; set; } = new List<string>();

    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("balanceSheet")]
    public required FinancialStatementsReportsResponseBalanceSheet BalanceSheet { get; set; }

    [JsonPropertyName("profitLoss")]
    public required FinancialStatementsReportsResponseProfitLoss ProfitLoss { get; set; }

    [JsonPropertyName("balanceSheetDetail")]
    public FinancialStatementsReportsResponseBalanceSheetDetail? BalanceSheetDetail { get; set; }

    [JsonPropertyName("profitLossDetail")]
    public FinancialStatementsReportsResponseProfitLossDetail? ProfitLossDetail { get; set; }

    [JsonPropertyName("equityChanges")]
    public IEnumerable<FinancialStatementsReportsResponseEquityChangesItem>? EquityChanges { get; set; }

    [JsonPropertyName("cashFlow")]
    public FinancialStatementsReportsResponseCashFlow? CashFlow { get; set; }

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
