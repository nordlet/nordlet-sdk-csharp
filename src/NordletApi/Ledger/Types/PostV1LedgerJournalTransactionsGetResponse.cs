using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerJournalTransactionsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("documentType")]
    public string? DocumentType { get; set; }

    [JsonPropertyName("documentId")]
    public string? DocumentId { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("status")]
    public required PostV1LedgerJournalTransactionsGetResponseStatus Status { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("postedAt")]
    public string? PostedAt { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<PostV1LedgerJournalTransactionsGetResponseEntriesItem> Entries { get; set; } =
        new List<PostV1LedgerJournalTransactionsGetResponseEntriesItem>();

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
