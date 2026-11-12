using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TransactionsIgnoreBankRequest
{
    [JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }

    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
