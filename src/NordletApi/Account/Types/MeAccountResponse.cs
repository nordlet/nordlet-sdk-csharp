using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MeAccountResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("user")]
    public required MeAccountResponseUser User { get; set; }

    [JsonPropertyName("locale")]
    public required string Locale { get; set; }

    [JsonPropertyName("activeCompanyId")]
    public string? ActiveCompanyId { get; set; }

    [JsonPropertyName("timeZone")]
    public required string TimeZone { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("billing")]
    public required MeAccountResponseBilling Billing { get; set; }

    [JsonPropertyName("referralPoints")]
    public required long ReferralPoints { get; set; }

    [JsonPropertyName("consent")]
    public required MeAccountResponseConsent Consent { get; set; }

    [JsonPropertyName("companies")]
    public IEnumerable<MeAccountResponseCompaniesItem> Companies { get; set; } =
        new List<MeAccountResponseCompaniesItem>();

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
