using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TopupCreateBillingRequest
{
    [JsonPropertyName("amountCents")]
    public required long AmountCents { get; set; }

    [JsonPropertyName("locale")]
    public TopupCreateBillingRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
