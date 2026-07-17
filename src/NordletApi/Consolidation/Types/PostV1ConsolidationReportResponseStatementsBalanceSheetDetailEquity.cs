using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportResponseStatementsBalanceSheetDetailEquity
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("capital")]
    public required string Capital { get; set; }

    [JsonPropertyName("reserves")]
    public required string Reserves { get; set; }

    [JsonPropertyName("retainedEarnings")]
    public required string RetainedEarnings { get; set; }

    [JsonPropertyName("otherEquity")]
    public required string OtherEquity { get; set; }

    [JsonPropertyName("periodResult")]
    public required string PeriodResult { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

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
