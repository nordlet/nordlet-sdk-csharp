using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TransactionsMatchManyBankRequest
{
    [JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }

    [JsonPropertyName("allocations")]
    public IEnumerable<TransactionsMatchManyBankRequestAllocationsItem> Allocations { get; set; } =
        new List<TransactionsMatchManyBankRequestAllocationsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
