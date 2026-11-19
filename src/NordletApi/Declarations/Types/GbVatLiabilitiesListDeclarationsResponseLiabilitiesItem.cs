using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatLiabilitiesListDeclarationsResponseLiabilitiesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("taxPeriod")]
    public GbVatLiabilitiesListDeclarationsResponseLiabilitiesItemTaxPeriod? TaxPeriod { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    [JsonPropertyName("originalAmount")]
    public required double OriginalAmount { get; set; }

    [JsonPropertyName("outstandingAmount")]
    public double? OutstandingAmount { get; set; }

    [JsonPropertyName("due")]
    public string? Due { get; set; }

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
