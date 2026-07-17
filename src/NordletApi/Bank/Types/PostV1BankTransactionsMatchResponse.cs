using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsMatchResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("counterpartyName")]
    public string? CounterpartyName { get; set; }

    [JsonPropertyName("counterpartyIban")]
    public string? CounterpartyIban { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("status")]
    public required PostV1BankTransactionsMatchResponseStatus Status { get; set; }

    [JsonPropertyName("matchedDocumentType")]
    public string? MatchedDocumentType { get; set; }

    [JsonPropertyName("matchedDocumentId")]
    public string? MatchedDocumentId { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
