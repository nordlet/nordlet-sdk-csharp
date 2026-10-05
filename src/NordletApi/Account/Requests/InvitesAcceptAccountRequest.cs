using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvitesAcceptAccountRequest
{
    [JsonPropertyName("token")]
    public required string Token { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("locale")]
    public InvitesAcceptAccountRequestLocale? Locale { get; set; }

    [JsonPropertyName("acceptTerms")]
    public bool? AcceptTerms { get; set; }

    [JsonPropertyName("acceptDpa")]
    public bool? AcceptDpa { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
