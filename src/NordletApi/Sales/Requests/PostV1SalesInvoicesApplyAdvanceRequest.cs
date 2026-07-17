using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesApplyAdvanceRequest
{
    [JsonPropertyName("advanceId")]
    public required string AdvanceId { get; set; }

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
