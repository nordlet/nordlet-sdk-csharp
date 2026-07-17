using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsFinancialStatementsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("category")]
    public required PostV1ReportsFinancialStatementsResponseCategory Category { get; set; }

    [JsonPropertyName("layout")]
    public required string Layout { get; set; }

    [JsonPropertyName("requiredStatements")]
    public IEnumerable<string> RequiredStatements { get; set; } = new List<string>();

    [JsonPropertyName("asOf")]
    public required string AsOf { get; set; }

    [JsonPropertyName("balanceSheet")]
    public required PostV1ReportsFinancialStatementsResponseBalanceSheet BalanceSheet { get; set; }

    [JsonPropertyName("profitLoss")]
    public required PostV1ReportsFinancialStatementsResponseProfitLoss ProfitLoss { get; set; }

    [JsonPropertyName("balanceSheetDetail")]
    public PostV1ReportsFinancialStatementsResponseBalanceSheetDetail? BalanceSheetDetail { get; set; }

    [JsonPropertyName("profitLossDetail")]
    public PostV1ReportsFinancialStatementsResponseProfitLossDetail? ProfitLossDetail { get; set; }

    [JsonPropertyName("equityChanges")]
    public IEnumerable<PostV1ReportsFinancialStatementsResponseEquityChangesItem>? EquityChanges { get; set; }

    [JsonPropertyName("cashFlow")]
    public PostV1ReportsFinancialStatementsResponseCashFlow? CashFlow { get; set; }

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
