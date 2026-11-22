using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsSalesTaxGetDeclarationsResponseJurisdictionsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("jurisdiction")]
    public required string Jurisdiction { get; set; }

    [JsonPropertyName("documents")]
    public required double Documents { get; set; }

    [JsonPropertyName("taxableSales")]
    public required string TaxableSales { get; set; }

    [JsonPropertyName("exemptSales")]
    public required string ExemptSales { get; set; }

    [JsonPropertyName("salesTax")]
    public required string SalesTax { get; set; }

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
