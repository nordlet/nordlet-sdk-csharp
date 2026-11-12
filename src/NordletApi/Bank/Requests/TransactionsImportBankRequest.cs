using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TransactionsImportBankRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("transactions")]
    public IEnumerable<TransactionsImportBankRequestTransactionsItem> Transactions { get; set; } =
        new List<TransactionsImportBankRequestTransactionsItem>();

    [JsonPropertyName("openingBalance")]
    public string? OpeningBalance { get; set; }

    [JsonPropertyName("closingBalance")]
    public string? ClosingBalance { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
