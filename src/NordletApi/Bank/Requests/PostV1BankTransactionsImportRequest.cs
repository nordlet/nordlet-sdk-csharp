using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsImportRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("transactions")]
    public IEnumerable<PostV1BankTransactionsImportRequestTransactionsItem> Transactions { get; set; } =
        new List<PostV1BankTransactionsImportRequestTransactionsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
