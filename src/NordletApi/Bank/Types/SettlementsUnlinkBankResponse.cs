using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettlementsUnlinkBankResponse : IJsonOnDeserialized
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
    public DateOnly? PayoutDate { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("feeTotal")]
    public required string FeeTotal { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("fxRate")]
    public string? FxRate { get; set; }

    [JsonPropertyName("status")]
    public required SettlementsUnlinkBankResponseStatus Status { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("bankTransactionId")]
    public string? BankTransactionId { get; set; }

    [JsonPropertyName("lineCount")]
    public required long LineCount { get; set; }

    [JsonPropertyName("matchedCount")]
    public required long MatchedCount { get; set; }

    [JsonPropertyName("unmatchedCount")]
    public required long UnmatchedCount { get; set; }

    [JsonPropertyName("clearedNet")]
    public string? ClearedNet { get; set; }

    [JsonPropertyName("clearingDifference")]
    public string? ClearingDifference { get; set; }

    [JsonPropertyName("clearingOpenCount")]
    public required long ClearingOpenCount { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
