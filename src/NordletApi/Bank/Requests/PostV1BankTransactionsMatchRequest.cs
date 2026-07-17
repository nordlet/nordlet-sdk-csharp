using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsMatchRequest
{
    [JsonPropertyName("transactionId")]
    public required string TransactionId { get; set; }

    [JsonPropertyName("documentType")]
    public required PostV1BankTransactionsMatchRequestDocumentType DocumentType { get; set; }

    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
