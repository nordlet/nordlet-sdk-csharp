using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsConnectionsStartRequest
{
    [JsonPropertyName("aspspName")]
    public required string AspspName { get; set; }

    [JsonPropertyName("aspspCountry")]
    public required string AspspCountry { get; set; }

    [JsonPropertyName("psuType")]
    public PostV1BankFeedsConnectionsStartRequestPsuType? PsuType { get; set; }

    [JsonPropertyName("redirectUrl")]
    public string? RedirectUrl { get; set; }

    [JsonPropertyName("validForDays")]
    public long? ValidForDays { get; set; }

    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
