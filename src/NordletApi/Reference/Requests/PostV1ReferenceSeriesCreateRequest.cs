using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceSeriesCreateRequest
{
    [JsonPropertyName("documentType")]
    public required string DocumentType { get; set; }

    [JsonPropertyName("prefix")]
    public string? Prefix { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("startAt")]
    public long? StartAt { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
