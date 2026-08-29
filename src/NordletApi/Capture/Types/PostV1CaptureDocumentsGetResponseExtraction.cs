using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureDocumentsGetResponseExtraction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("supplier")]
    public required PostV1CaptureDocumentsGetResponseExtractionSupplier Supplier { get; set; }

    [JsonPropertyName("documentNumber")]
    public string? DocumentNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public string? DocumentDate { get; set; }

    [JsonPropertyName("dueDate")]
    public string? DueDate { get; set; }

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
    public IEnumerable<PostV1CaptureDocumentsGetResponseExtractionLinesItem> Lines { get; set; } =
        new List<PostV1CaptureDocumentsGetResponseExtractionLinesItem>();

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
