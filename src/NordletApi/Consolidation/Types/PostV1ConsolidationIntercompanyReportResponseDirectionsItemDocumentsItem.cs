using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItem
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
    public required string IssueDate { get; set; }

    [JsonPropertyName("type")]
    public required PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemType Type { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemPaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("match")]
    public required PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemMatch Match { get; set; }

    [JsonPropertyName("counterpart")]
    public PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemCounterpart? Counterpart { get; set; }

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
