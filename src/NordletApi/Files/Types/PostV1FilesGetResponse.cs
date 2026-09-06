using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1FilesGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("entity")]
    public required string Entity { get; set; }

    [JsonPropertyName("entityId")]
    public string? EntityId { get; set; }

    [JsonPropertyName("fileName")]
    public required string FileName { get; set; }

    [JsonPropertyName("mimeType")]
    public required string MimeType { get; set; }

    [JsonPropertyName("sizeBytes")]
    public required long SizeBytes { get; set; }

    [JsonPropertyName("sha256")]
    public required string Sha256 { get; set; }

    [JsonPropertyName("storageKey")]
    public required string StorageKey { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

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
