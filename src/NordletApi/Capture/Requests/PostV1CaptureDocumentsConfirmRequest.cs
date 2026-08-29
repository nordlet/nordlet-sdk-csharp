using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureDocumentsConfirmRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("newSupplier")]
    public PostV1CaptureDocumentsConfirmRequestNewSupplier? NewSupplier { get; set; }

    [JsonPropertyName("documentNumber")]
    public required string DocumentNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public required string DocumentDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1CaptureDocumentsConfirmRequestLinesItem> Lines { get; set; } =
        new List<PostV1CaptureDocumentsConfirmRequestLinesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
