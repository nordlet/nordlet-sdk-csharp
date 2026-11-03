using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record OauthAuthorizeDescribeAccountRequest
{
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    [JsonPropertyName("redirectUri")]
    public string? RedirectUri { get; set; }

    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }

    [JsonPropertyName("codeChallenge")]
    public string? CodeChallenge { get; set; }

    [JsonPropertyName("codeChallengeMethod")]
    public string? CodeChallengeMethod { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    [JsonPropertyName("resource")]
    public string? Resource { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
