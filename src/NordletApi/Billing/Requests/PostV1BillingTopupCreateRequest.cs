using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BillingTopupCreateRequest
{
    [JsonPropertyName("amountCents")]
    public required long AmountCents { get; set; }

    [JsonPropertyName("locale")]
    public PostV1BillingTopupCreateRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
