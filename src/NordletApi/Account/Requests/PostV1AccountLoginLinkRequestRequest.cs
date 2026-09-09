using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountLoginLinkRequestRequest
{
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    [JsonPropertyName("locale")]
    public PostV1AccountLoginLinkRequestRequestLocale? Locale { get; set; }

    [JsonPropertyName("acceptTerms")]
    public bool? AcceptTerms { get; set; }

    [JsonPropertyName("acceptDpa")]
    public bool? AcceptDpa { get; set; }

    [JsonPropertyName("referralCode")]
    public string? ReferralCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
