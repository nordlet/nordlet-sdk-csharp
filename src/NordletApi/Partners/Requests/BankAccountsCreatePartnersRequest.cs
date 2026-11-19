using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BankAccountsCreatePartnersRequest
{
    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    /// <summary>
    /// Sort code, routing number or other national bank code, for an account without an IBAN
    /// </summary>
    [JsonPropertyName("bankCode")]
    public string? BankCode { get; set; }

    /// <summary>
    /// Account number, for an account without an IBAN
    /// </summary>
    [JsonPropertyName("bankAccountNumber")]
    public string? BankAccountNumber { get; set; }

    /// <summary>
    /// Checking or savings account; a US ACH file needs it
    /// </summary>
    [JsonPropertyName("accountType")]
    public BankAccountsCreatePartnersRequestAccountType? AccountType { get; set; }

    [JsonPropertyName("bankName")]
    public string? BankName { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    /// <summary>
    /// Defaults to the company's base currency
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
