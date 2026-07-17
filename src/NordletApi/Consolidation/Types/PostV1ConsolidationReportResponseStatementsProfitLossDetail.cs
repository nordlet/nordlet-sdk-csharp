using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseStatementsProfitLossDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("salesRevenue")]
    public required string SalesRevenue { get; set; }

    [JsonPropertyName("costOfSales")]
    public required string CostOfSales { get; set; }

    [JsonPropertyName("grossProfit")]
    public required string GrossProfit { get; set; }

    [JsonPropertyName("sellingExpenses")]
    public required string SellingExpenses { get; set; }

    [JsonPropertyName("adminExpenses")]
    public required string AdminExpenses { get; set; }

    [JsonPropertyName("operatingProfit")]
    public required string OperatingProfit { get; set; }

    [JsonPropertyName("otherActivityResult")]
    public required string OtherActivityResult { get; set; }

    [JsonPropertyName("financialActivityResult")]
    public required string FinancialActivityResult { get; set; }

    [JsonPropertyName("profitBeforeTax")]
    public required string ProfitBeforeTax { get; set; }

    [JsonPropertyName("incomeTax")]
    public required string IncomeTax { get; set; }

    [JsonPropertyName("netProfit")]
    public required string NetProfit { get; set; }

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
