using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseStatementsBalanceSheet : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("nonCurrentAssets")]
    public required string NonCurrentAssets { get; set; }

    [JsonPropertyName("currentAssets")]
    public required string CurrentAssets { get; set; }

    [JsonPropertyName("totalAssets")]
    public required string TotalAssets { get; set; }

    [JsonPropertyName("equity")]
    public required string Equity { get; set; }

    [JsonPropertyName("ofWhichResult")]
    public required string OfWhichResult { get; set; }

    [JsonPropertyName("liabilities")]
    public required string Liabilities { get; set; }

    [JsonPropertyName("totalEquityAndLiabilities")]
    public required string TotalEquityAndLiabilities { get; set; }

    [JsonPropertyName("balanced")]
    public required bool Balanced { get; set; }

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
