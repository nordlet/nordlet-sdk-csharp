using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceExchangeRatesOverridesDeleteRequest
{
    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
