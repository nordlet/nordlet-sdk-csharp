using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountLocaleSetRequest
{
    [JsonPropertyName("locale")]
    public required PostV1AccountLocaleSetRequestLocale Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
