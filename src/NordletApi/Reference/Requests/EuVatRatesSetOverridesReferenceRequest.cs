using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuVatRatesSetOverridesReferenceRequest
{
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<EuVatRatesSetOverridesReferenceRequestRatesItem> Rates { get; set; } =
        new List<EuVatRatesSetOverridesReferenceRequestRatesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
