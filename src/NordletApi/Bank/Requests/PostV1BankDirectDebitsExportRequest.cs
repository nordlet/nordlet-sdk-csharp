using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankDirectDebitsExportRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("saleInvoiceIds")]
    public IEnumerable<string> SaleInvoiceIds { get; set; } = new List<string>();

    [JsonPropertyName("collectionDate")]
    public string? CollectionDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
