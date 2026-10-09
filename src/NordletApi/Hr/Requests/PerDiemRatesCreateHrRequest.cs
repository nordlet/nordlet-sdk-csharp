using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PerDiemRatesCreateHrRequest
{
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("dailyAmount")]
    public required string DailyAmount { get; set; }

    [JsonPropertyName("validFrom")]
    public required DateOnly ValidFrom { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
