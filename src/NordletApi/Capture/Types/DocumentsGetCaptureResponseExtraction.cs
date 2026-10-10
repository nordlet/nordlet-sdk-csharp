using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DocumentsGetCaptureResponseExtraction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("documentType")]
    public DocumentsGetCaptureResponseExtractionDocumentType? DocumentType { get; set; }

    [JsonPropertyName("supplier")]
    public required DocumentsGetCaptureResponseExtractionSupplier Supplier { get; set; }

    [JsonPropertyName("documentNumber")]
    public string? DocumentNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public DateOnly? DocumentDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("netTotal")]
    public string? NetTotal { get; set; }

    [JsonPropertyName("vatTotal")]
    public string? VatTotal { get; set; }

    [JsonPropertyName("grossTotal")]
    public string? GrossTotal { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<DocumentsGetCaptureResponseExtractionLinesItem> Lines { get; set; } =
        new List<DocumentsGetCaptureResponseExtractionLinesItem>();

    [JsonPropertyName("oppositeLines")]
    public IEnumerable<DocumentsGetCaptureResponseExtractionOppositeLinesItem>? OppositeLines { get; set; }

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
