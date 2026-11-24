using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesProposeLinesPurchasesRequest
{
    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("documentDate")]
    public DateOnly? DocumentDate { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<InvoicesProposeLinesPurchasesRequestLinesItem> Lines { get; set; } =
        new List<InvoicesProposeLinesPurchasesRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
