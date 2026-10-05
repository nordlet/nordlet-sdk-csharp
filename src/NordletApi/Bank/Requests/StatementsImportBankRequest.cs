using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StatementsImportBankRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("format")]
    public StatementsImportBankRequestFormat? Format { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// Stripe transfers export (plain CSV or base64) used to post lender payouts and commissions
    /// </summary>
    [JsonPropertyName("transfersCsv")]
    public string? TransfersCsv { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
