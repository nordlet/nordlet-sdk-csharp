using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankSettlementsImportResponseBatchesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("payoutId")]
    public required string PayoutId { get; set; }

    [JsonPropertyName("payoutDate")]
    public string? PayoutDate { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("feeTotal")]
    public required string FeeTotal { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("status")]
    public required PostV1BankSettlementsImportResponseBatchesItemStatus Status { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("lineCount")]
    public required long LineCount { get; set; }

    [JsonPropertyName("matchedCount")]
    public required long MatchedCount { get; set; }

    [JsonPropertyName("unmatchedCount")]
    public required long UnmatchedCount { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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
