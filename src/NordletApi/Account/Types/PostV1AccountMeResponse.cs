using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountMeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("user")]
    public required PostV1AccountMeResponseUser User { get; set; }

    [JsonPropertyName("locale")]
    public required string Locale { get; set; }

    [JsonPropertyName("activeCompanyId")]
    public string? ActiveCompanyId { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("billing")]
    public required PostV1AccountMeResponseBilling Billing { get; set; }

    [JsonPropertyName("companies")]
    public IEnumerable<PostV1AccountMeResponseCompaniesItem> Companies { get; set; } =
        new List<PostV1AccountMeResponseCompaniesItem>();

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
