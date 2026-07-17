using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersCreditCheckResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("creditLimit")]
    public string? CreditLimit { get; set; }

    [JsonPropertyName("openReceivables")]
    public required string OpenReceivables { get; set; }

    [JsonPropertyName("additionalAmount")]
    public required string AdditionalAmount { get; set; }

    [JsonPropertyName("totalExposure")]
    public required string TotalExposure { get; set; }

    [JsonPropertyName("available")]
    public string? Available { get; set; }

    [JsonPropertyName("exceeded")]
    public required bool Exceeded { get; set; }

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
