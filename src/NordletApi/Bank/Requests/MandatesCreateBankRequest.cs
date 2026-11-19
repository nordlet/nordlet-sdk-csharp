using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MandatesCreateBankRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    /// <summary>
    /// Sort code (Bacs) or routing number (ACH), for a mandate without an IBAN
    /// </summary>
    [JsonPropertyName("bankCode")]
    public string? BankCode { get; set; }

    /// <summary>
    /// Account number, for a mandate without an IBAN
    /// </summary>
    [JsonPropertyName("bankAccountNumber")]
    public string? BankAccountNumber { get; set; }

    /// <summary>
    /// Checking or savings account; a US ACH file needs it
    /// </summary>
    [JsonPropertyName("accountType")]
    public MandatesCreateBankRequestAccountType? AccountType { get; set; }

    [JsonPropertyName("scheme")]
    public MandatesCreateBankRequestScheme? Scheme { get; set; }

    [JsonPropertyName("sequenceType")]
    public MandatesCreateBankRequestSequenceType? SequenceType { get; set; }

    [JsonPropertyName("signatureDate")]
    public required DateOnly SignatureDate { get; set; }

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
