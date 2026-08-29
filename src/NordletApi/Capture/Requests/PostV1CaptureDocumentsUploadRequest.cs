using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CaptureDocumentsUploadRequest
{
    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    /// <summary>
    /// Base64-encoded scan, photo or PDF of the supplier document
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
