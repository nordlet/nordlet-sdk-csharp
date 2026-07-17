using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1FilesUploadRequest
{
    [JsonPropertyName("entity")]
    public required string Entity { get; set; }

    [JsonPropertyName("entityId")]
    public required string EntityId { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    /// <summary>
    /// Base64-encoded file content
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
