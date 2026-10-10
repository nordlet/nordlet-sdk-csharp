using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DocumentsConfirmCaptureRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("newSupplier")]
    public DocumentsConfirmCaptureRequestNewSupplier? NewSupplier { get; set; }

    [JsonPropertyName("type")]
    public DocumentsConfirmCaptureRequestType? Type { get; set; }

    [JsonPropertyName("documentNumber")]
    public required string DocumentNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public required DateOnly DocumentDate { get; set; }

    [JsonPropertyName("dueDate")]
    public DateOnly? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<DocumentsConfirmCaptureRequestLinesItem> Lines { get; set; } =
        new List<DocumentsConfirmCaptureRequestLinesItem>();

    [JsonPropertyName("oppositeLines")]
    public IEnumerable<DocumentsConfirmCaptureRequestOppositeLinesItem>? OppositeLines { get; set; }

    [JsonPropertyName("oppositeDocumentNumber")]
    public string? OppositeDocumentNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
