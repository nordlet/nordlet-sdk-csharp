using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesGetPublicResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required InvoicesGetPublicResponseType Type { get; set; }

    [JsonPropertyName("status")]
    public required InvoicesGetPublicResponseStatus Status { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required InvoicesGetPublicResponsePaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("issueDate")]
    public DateOnly? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public required string VatTotal { get; set; }

    [JsonPropertyName("salesTaxPercent")]
    public string? SalesTaxPercent { get; set; }

    [JsonPropertyName("salesTaxTotal")]
    public required string SalesTaxTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paidAmount")]
    public required string PaidAmount { get; set; }

    [JsonPropertyName("paidOn")]
    public string? PaidOn { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("payUrl")]
    public string? PayUrl { get; set; }

    [JsonPropertyName("seller")]
    public required InvoicesGetPublicResponseSeller Seller { get; set; }

    [JsonPropertyName("buyer")]
    public required InvoicesGetPublicResponseBuyer Buyer { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<InvoicesGetPublicResponseLinesItem> Lines { get; set; } =
        new List<InvoicesGetPublicResponseLinesItem>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
