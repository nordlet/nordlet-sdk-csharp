using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsSuggestMatchesRequest
{
    [JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }

    [JsonPropertyName("limit")]
    public long? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
