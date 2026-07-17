using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceBanksUpsertRequest
{
    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("bic")]
    public required string Bic { get; set; }

    [JsonPropertyName("bankCode")]
    public string? BankCode { get; set; }

    [JsonPropertyName("isActive")]
    public bool? IsActive { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
