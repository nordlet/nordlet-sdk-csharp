using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlKsefReceivedFetchDeclarationsRequest
{
    [JsonPropertyName("ksefNumber")]
    public required string KsefNumber { get; set; }

    [JsonPropertyName("purchaseInvoiceId")]
    public string? PurchaseInvoiceId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
