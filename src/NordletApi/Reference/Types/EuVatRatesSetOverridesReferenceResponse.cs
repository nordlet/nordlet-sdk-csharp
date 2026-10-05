using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuVatRatesSetOverridesReferenceResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("countryCode")]
    public required string CountryCode { get; set; }

    [JsonPropertyName("source")]
    public required EuVatRatesSetOverridesReferenceResponseSource Source { get; set; }

    [JsonPropertyName("notice")]
    public required string Notice { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<EuVatRatesSetOverridesReferenceResponseRowsItem> Rows { get; set; } =
        new List<EuVatRatesSetOverridesReferenceResponseRowsItem>();

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
