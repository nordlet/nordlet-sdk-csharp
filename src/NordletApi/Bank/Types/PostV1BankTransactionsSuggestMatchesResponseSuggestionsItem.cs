using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankTransactionsSuggestMatchesResponseSuggestionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("documentType")]
    public required PostV1BankTransactionsSuggestMatchesResponseSuggestionsItemDocumentType DocumentType { get; set; }

    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    [JsonPropertyName("number")]
    public required string Number { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("remaining")]
    public required string Remaining { get; set; }

    [JsonPropertyName("score")]
    public required long Score { get; set; }

    [JsonPropertyName("reasons")]
    public IEnumerable<string> Reasons { get; set; } = new List<string>();

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
