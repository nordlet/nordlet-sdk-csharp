using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankMandatesUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("reference")]
    public required string Reference { get; set; }

    [JsonPropertyName("scheme")]
    public required PostV1BankMandatesUpdateResponseScheme Scheme { get; set; }

    [JsonPropertyName("sequenceType")]
    public required PostV1BankMandatesUpdateResponseSequenceType SequenceType { get; set; }

    [JsonPropertyName("status")]
    public required PostV1BankMandatesUpdateResponseStatus Status { get; set; }

    [JsonPropertyName("debtorName")]
    public required string DebtorName { get; set; }

    [JsonPropertyName("iban")]
    public required string Iban { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    [JsonPropertyName("signatureDate")]
    public required string SignatureDate { get; set; }

    [JsonPropertyName("collectionsCount")]
    public required long CollectionsCount { get; set; }

    [JsonPropertyName("lastCollectionDate")]
    public string? LastCollectionDate { get; set; }

    [JsonPropertyName("expiresOn")]
    public required string ExpiresOn { get; set; }

    [JsonPropertyName("cancelledAt")]
    public string? CancelledAt { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

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
