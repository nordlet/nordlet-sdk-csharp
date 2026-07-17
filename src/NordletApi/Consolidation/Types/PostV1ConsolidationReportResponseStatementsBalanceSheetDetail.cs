using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseStatementsBalanceSheetDetail : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nonCurrentAssets")]
    public required PostV1ConsolidationReportResponseStatementsBalanceSheetDetailNonCurrentAssets NonCurrentAssets { get; set; }

    [JsonPropertyName("currentAssets")]
    public required PostV1ConsolidationReportResponseStatementsBalanceSheetDetailCurrentAssets CurrentAssets { get; set; }

    [JsonPropertyName("equity")]
    public required PostV1ConsolidationReportResponseStatementsBalanceSheetDetailEquity Equity { get; set; }

    [JsonPropertyName("liabilities")]
    public required PostV1ConsolidationReportResponseStatementsBalanceSheetDetailLiabilities Liabilities { get; set; }

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
