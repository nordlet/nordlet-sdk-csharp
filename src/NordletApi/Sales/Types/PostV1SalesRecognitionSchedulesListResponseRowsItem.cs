using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesRecognitionSchedulesListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("invoiceId")]
    public required string InvoiceId { get; set; }

    [JsonPropertyName("invoiceLineId")]
    public required string InvoiceLineId { get; set; }

    [JsonPropertyName("method")]
    public required PostV1SalesRecognitionSchedulesListResponseRowsItemMethod Method { get; set; }

    [JsonPropertyName("status")]
    public required PostV1SalesRecognitionSchedulesListResponseRowsItemStatus Status { get; set; }

    [JsonPropertyName("scheduleDate")]
    public string? ScheduleDate { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("recognizedAt")]
    public string? RecognizedAt { get; set; }

    [JsonPropertyName("sortOrder")]
    public required long SortOrder { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
