using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsRecordRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("documentType")]
    public required PostV1BankTransactionsRecordRequestDocumentType DocumentType { get; set; }

    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
