using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record IntercompanyReportConsolidationResponseDirectionsItemDocumentsItem
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("sourceInvoiceId")]
    public required string SourceInvoiceId { get; set; }

    [JsonPropertyName("fullNumber")]
    public required string FullNumber { get; set; }

    [JsonPropertyName("issueDate")]
    public required DateOnly IssueDate { get; set; }

    [JsonPropertyName("type")]
    public required IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemType Type { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemPaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("match")]
    public required IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemMatch Match { get; set; }

    [JsonPropertyName("counterpart")]
    public IntercompanyReportConsolidationResponseDirectionsItemDocumentsItemCounterpart? Counterpart { get; set; }

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
