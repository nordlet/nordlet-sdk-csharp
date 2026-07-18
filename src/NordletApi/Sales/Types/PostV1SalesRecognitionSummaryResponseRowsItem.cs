using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionSummaryResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("invoiceFullNumber")]
    public string? InvoiceFullNumber { get; set; }

    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("lineDescription")]
    public required string LineDescription { get; set; }

    [JsonPropertyName("method")]
    public required PostV1SalesRecognitionSummaryResponseRowsItemMethod Method { get; set; }

    [JsonPropertyName("deferredTotal")]
    public required string DeferredTotal { get; set; }

    [JsonPropertyName("recognizedToDate")]
    public required string RecognizedToDate { get; set; }

    [JsonPropertyName("remaining")]
    public required string Remaining { get; set; }

    [JsonPropertyName("pendingCount")]
    public required long PendingCount { get; set; }

    [JsonPropertyName("nextScheduleDate")]
    public string? NextScheduleDate { get; set; }

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
