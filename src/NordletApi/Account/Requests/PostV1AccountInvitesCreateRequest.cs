using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountInvitesCreateRequest
{
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("role")]
    public required PostV1AccountInvitesCreateRequestRole Role { get; set; }

    [JsonPropertyName("locale")]
    public PostV1AccountInvitesCreateRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
