using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PaymentsExportBankRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("purchaseInvoiceIds")]
    public IEnumerable<string> PurchaseInvoiceIds { get; set; } = new List<string>();

    [JsonPropertyName("executionDate")]
    public DateOnly? ExecutionDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
