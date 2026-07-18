using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceEuVatRatesSetOverridesRequest
{
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem> Rates { get; set; } =
        new List<PostV1ReferenceEuVatRatesSetOverridesRequestRatesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
