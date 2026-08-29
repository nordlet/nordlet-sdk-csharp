using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemCounterpart
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemCounterpartStatus Status { get; set; }

    [JsonPropertyName("paymentStatus")]
    public required PostV1ConsolidationIntercompanyReportResponseDirectionsItemDocumentsItemCounterpartPaymentStatus PaymentStatus { get; set; }

    [JsonPropertyName("grossTotal")]
    public required string GrossTotal { get; set; }

    [JsonPropertyName("amountsMatch")]
    public required bool AmountsMatch { get; set; }

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
