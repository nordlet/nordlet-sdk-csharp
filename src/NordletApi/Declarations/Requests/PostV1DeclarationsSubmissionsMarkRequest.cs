using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsSubmissionsMarkRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("status")]
    public required PostV1DeclarationsSubmissionsMarkRequestStatus Status { get; set; }

    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
