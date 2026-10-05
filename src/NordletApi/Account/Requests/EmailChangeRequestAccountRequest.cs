using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EmailChangeRequestAccountRequest
{
    [JsonPropertyName("newEmail")]
    public required string NewEmail { get; set; }

    [JsonPropertyName("locale")]
    public EmailChangeRequestAccountRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
