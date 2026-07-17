using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerJournalTransactionsGetResponseEntriesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("accountId")]
    public required string AccountId { get; set; }

    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; set; }

    [JsonPropertyName("accountName")]
    public required string AccountName { get; set; }

    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    [JsonPropertyName("debit")]
    public required string Debit { get; set; }

    [JsonPropertyName("credit")]
    public required string Credit { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
