using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesInvoicesGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1SalesInvoicesGetResponseType Type { get; set; }

    [JsonPropertyName("status")]
    public required PostV1SalesInvoicesGetResponseStatus Status { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required PostV1SalesInvoicesGetResponsePaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("number")]
    public long? Number { get; set; }

    [JsonPropertyName("fullNumber")]
    public string? FullNumber { get; set; }

    [JsonPropertyName("issueDate")]
    public string? IssueDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("netTotal")]
    public required string NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public required string VatTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paidAmount")]
    public required string PaidAmount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("appliedToInvoiceId")]
    public string? AppliedToInvoiceId { get; set; }

    [JsonPropertyName("creditedInvoiceId")]
    public string? CreditedInvoiceId { get; set; }

    [JsonPropertyName("vatScheme")]
    public PostV1SalesInvoicesGetResponseVatScheme? VatScheme { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("deemedSupplier")]
    public required bool DeemedSupplier { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1SalesInvoicesGetResponseLinesItem> Lines { get; set; } =
        new List<PostV1SalesInvoicesGetResponseLinesItem>();

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
