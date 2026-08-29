using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureDocumentsExtractResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("fileId")]
    public required string FileId { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    [JsonPropertyName("sizeBytes")]
    public required long SizeBytes { get; set; }

    [JsonPropertyName("status")]
    public required PostV1CaptureDocumentsExtractResponseStatus Status { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("pagesProcessed")]
    public long? PagesProcessed { get; set; }

    [JsonPropertyName("extraction")]
    public PostV1CaptureDocumentsExtractResponseExtraction? Extraction { get; set; }

    [JsonPropertyName("matchedPartnerId")]
    public string? MatchedPartnerId { get; set; }

    [JsonPropertyName("purchaseInvoiceId")]
    public string? PurchaseInvoiceId { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonPropertyName("rawText")]
    public string? RawText { get; set; }

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
