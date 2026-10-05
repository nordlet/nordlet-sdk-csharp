using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LocaleSetAccountRequest
{
    [JsonPropertyName("locale")]
    public required LocaleSetAccountRequestLocale Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
