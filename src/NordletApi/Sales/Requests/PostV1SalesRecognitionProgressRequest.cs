using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionProgressRequest
{
    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("percentComplete")]
    public required string PercentComplete { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
