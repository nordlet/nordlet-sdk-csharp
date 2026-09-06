using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsSyncResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    [JsonPropertyName("imported")]
    public required long Imported { get; set; }

    [JsonPropertyName("skipped")]
    public required long Skipped { get; set; }

    [JsonPropertyName("posted")]
    public required long Posted { get; set; }

    [JsonPropertyName("partnersCreated")]
    public required long PartnersCreated { get; set; }

    [JsonPropertyName("invoicesCreated")]
    public required long InvoicesCreated { get; set; }

    [JsonPropertyName("invoicesLinked")]
    public required long InvoicesLinked { get; set; }

    [JsonPropertyName("paymentsMatched")]
    public required long PaymentsMatched { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("accounts")]
    public IEnumerable<PostV1BankFeedsSyncResponseAccountsItem> Accounts { get; set; } =
        new List<PostV1BankFeedsSyncResponseAccountsItem>();

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
