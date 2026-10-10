using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesApplyAdvanceSalesRequest
{
    [JsonPropertyName("advanceId")]
    public required string AdvanceId { get; set; }

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Gross amount of the advance to apply; defaults to the unapplied advance or the unpaid balance of the invoice, whichever is smaller
    /// </summary>
    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
