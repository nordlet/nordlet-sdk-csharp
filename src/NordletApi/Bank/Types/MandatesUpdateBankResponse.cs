using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MandatesUpdateBankResponse : IJsonOnDeserialized
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
    public required MandatesUpdateBankResponseScheme Scheme { get; set; }

    [JsonPropertyName("sequenceType")]
    public required MandatesUpdateBankResponseSequenceType SequenceType { get; set; }

    [JsonPropertyName("status")]
    public required MandatesUpdateBankResponseStatus Status { get; set; }

    [JsonPropertyName("debtorName")]
    public required string DebtorName { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    [JsonPropertyName("bankCode")]
    public string? BankCode { get; set; }

    [JsonPropertyName("bankAccountNumber")]
    public string? BankAccountNumber { get; set; }

    /// <summary>
    /// Checking or savings account; a US ACH file needs it
    /// </summary>
    [JsonPropertyName("accountType")]
    public MandatesUpdateBankResponseAccountType? AccountType { get; set; }

    [JsonPropertyName("signatureDate")]
    public required DateOnly SignatureDate { get; set; }

    [JsonPropertyName("collectionsCount")]
    public required long CollectionsCount { get; set; }

    [JsonPropertyName("lastCollectionDate")]
    public DateOnly? LastCollectionDate { get; set; }

    [JsonPropertyName("expiresOn")]
    public string? ExpiresOn { get; set; }

    [JsonPropertyName("lodgedOn")]
    public string? LodgedOn { get; set; }

    [JsonPropertyName("cancellationLodgedOn")]
    public string? CancellationLodgedOn { get; set; }

    [JsonPropertyName("cancelledAt")]
    public DateTime? CancelledAt { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
