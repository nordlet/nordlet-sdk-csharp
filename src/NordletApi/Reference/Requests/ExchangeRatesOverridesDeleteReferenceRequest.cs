using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ExchangeRatesOverridesDeleteReferenceRequest
{
    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
