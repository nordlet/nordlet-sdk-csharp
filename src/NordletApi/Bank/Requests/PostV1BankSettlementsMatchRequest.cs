using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankSettlementsMatchRequest
{
    [JsonPropertyName("lineId")]
    public required string LineId { get; set; }

    [JsonPropertyName("invoiceId")]
    public string? InvoiceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
