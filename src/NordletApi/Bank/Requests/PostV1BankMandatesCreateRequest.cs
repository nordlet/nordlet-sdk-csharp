using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankMandatesCreateRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("iban")]
    public required string Iban { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    [JsonPropertyName("scheme")]
    public PostV1BankMandatesCreateRequestScheme? Scheme { get; set; }

    [JsonPropertyName("sequenceType")]
    public PostV1BankMandatesCreateRequestSequenceType? SequenceType { get; set; }

    [JsonPropertyName("signatureDate")]
    public required string SignatureDate { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("debtorName")]
    public string? DebtorName { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
