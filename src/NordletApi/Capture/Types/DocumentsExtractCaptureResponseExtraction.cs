using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DocumentsExtractCaptureResponseExtraction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("documentType")]
    public DocumentsExtractCaptureResponseExtractionDocumentType? DocumentType { get; set; }

    [JsonPropertyName("supplier")]
    public required DocumentsExtractCaptureResponseExtractionSupplier Supplier { get; set; }

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
    public IEnumerable<DocumentsExtractCaptureResponseExtractionLinesItem> Lines { get; set; } =
        new List<DocumentsExtractCaptureResponseExtractionLinesItem>();

    [JsonPropertyName("oppositeLines")]
    public IEnumerable<DocumentsExtractCaptureResponseExtractionOppositeLinesItem>? OppositeLines { get; set; }

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
