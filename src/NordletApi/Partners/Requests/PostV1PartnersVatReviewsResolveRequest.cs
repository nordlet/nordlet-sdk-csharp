using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersVatReviewsResolveRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("resolution")]
    public required PostV1PartnersVatReviewsResolveRequestResolution Resolution { get; set; }

    [JsonPropertyName("note")]
    public string? Note { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
