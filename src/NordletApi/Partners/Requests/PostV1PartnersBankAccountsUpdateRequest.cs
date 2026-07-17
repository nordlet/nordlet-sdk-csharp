using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersBankAccountsUpdateRequest
{
    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("bankName")]
    public string? BankName { get; set; }

    [JsonPropertyName("bic")]
    public string? Bic { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonPropertyName("isDefault")]
    public bool? IsDefault { get; set; }

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
