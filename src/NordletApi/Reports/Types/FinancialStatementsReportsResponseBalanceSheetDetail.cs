using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FinancialStatementsReportsResponseBalanceSheetDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nonCurrentAssets")]
    public required FinancialStatementsReportsResponseBalanceSheetDetailNonCurrentAssets NonCurrentAssets { get; set; }

    [JsonPropertyName("currentAssets")]
    public required FinancialStatementsReportsResponseBalanceSheetDetailCurrentAssets CurrentAssets { get; set; }

    [JsonPropertyName("equity")]
    public required FinancialStatementsReportsResponseBalanceSheetDetailEquity Equity { get; set; }

    [JsonPropertyName("liabilities")]
    public required FinancialStatementsReportsResponseBalanceSheetDetailLiabilities Liabilities { get; set; }

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
