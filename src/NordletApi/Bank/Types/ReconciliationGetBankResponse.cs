using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ReconciliationGetBankResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    [JsonPropertyName("statementBalance")]
    public string? StatementBalance { get; set; }

    [JsonPropertyName("statementBalanceSource")]
    public ReconciliationGetBankResponseStatementBalanceSource? StatementBalanceSource { get; set; }

    [JsonPropertyName("statementClosingDate")]
    public DateOnly? StatementClosingDate { get; set; }

    [JsonPropertyName("ledgerBalance")]
    public required string LedgerBalance { get; set; }

    [JsonPropertyName("difference")]
    public string? Difference { get; set; }

    [JsonPropertyName("unbookedCount")]
    public required long UnbookedCount { get; set; }

    [JsonPropertyName("unbookedTotal")]
    public required string UnbookedTotal { get; set; }

    [JsonPropertyName("unbookedLines")]
    public IEnumerable<ReconciliationGetBankResponseUnbookedLinesItem> UnbookedLines { get; set; } =
        new List<ReconciliationGetBankResponseUnbookedLinesItem>();

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
