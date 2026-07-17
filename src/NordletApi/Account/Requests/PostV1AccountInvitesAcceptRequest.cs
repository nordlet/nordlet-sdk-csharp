using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountInvitesAcceptRequest
{
    [JsonPropertyName("token")]
    public required string Token { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("locale")]
    public PostV1AccountInvitesAcceptRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
