using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PlKsefReceiptDeclarationsRequest
{
    [JsonPropertyName("sessionReferenceNumber")]
    public string? SessionReferenceNumber { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
