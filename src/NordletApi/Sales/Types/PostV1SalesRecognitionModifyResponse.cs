using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionModifyResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("approach")]
    public required PostV1SalesRecognitionModifyResponseApproach Approach { get; set; }

    [JsonPropertyName("cancelledCount")]
    public required long CancelledCount { get; set; }

    [JsonPropertyName("newPendingCount")]
    public required long NewPendingCount { get; set; }

    [JsonPropertyName("catchUpAmount")]
    public required string CatchUpAmount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("newEndDate")]
    public string? NewEndDate { get; set; }

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
