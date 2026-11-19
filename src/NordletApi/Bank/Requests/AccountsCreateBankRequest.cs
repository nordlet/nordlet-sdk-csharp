using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountsCreateBankRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public AccountsCreateBankRequestType? Type { get; set; }

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
    /// What the bank gave the company for payment files from this account: the Bacs service user number for a UK account, the ACH Immediate Origin and Company Identification for a US account
    /// </summary>
    [JsonPropertyName("paymentFileSettings")]
    public AccountsCreateBankRequestPaymentFileSettings? PaymentFileSettings { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; set; }

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
