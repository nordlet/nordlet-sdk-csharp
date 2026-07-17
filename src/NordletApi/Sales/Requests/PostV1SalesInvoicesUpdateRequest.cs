using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("issueDate")]
    public string? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("vatScheme")]
    public PostV1SalesInvoicesUpdateRequestVatScheme? VatScheme { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("deemedSupplier")]
    public bool? DeemedSupplier { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1SalesInvoicesUpdateRequestLinesItem>? Lines { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
