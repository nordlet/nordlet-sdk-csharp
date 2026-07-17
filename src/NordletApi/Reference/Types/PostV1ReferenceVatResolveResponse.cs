using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceVatResolveResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("scheme")]
    public required PostV1ReferenceVatResolveResponseScheme Scheme { get; set; }

    [JsonPropertyName("vatCountryCode")]
    public string? VatCountryCode { get; set; }

    [JsonPropertyName("reverseCharge")]
    public required bool ReverseCharge { get; set; }

    [JsonPropertyName("deemedSupplier")]
    public required bool DeemedSupplier { get; set; }

    [JsonPropertyName("zeroRated")]
    public required bool ZeroRated { get; set; }

    [JsonPropertyName("rates")]
    public IEnumerable<PostV1ReferenceVatResolveResponseRatesItem> Rates { get; set; } =
        new List<PostV1ReferenceVatResolveResponseRatesItem>();

    [JsonPropertyName("legalBasis")]
    public required string LegalBasis { get; set; }

    [JsonPropertyName("notes")]
    public IEnumerable<string> Notes { get; set; } = new List<string>();

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
