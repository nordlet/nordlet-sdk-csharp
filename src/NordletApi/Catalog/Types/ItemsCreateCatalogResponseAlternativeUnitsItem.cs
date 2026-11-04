using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItemsCreateCatalogResponseAlternativeUnitsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("unitCode")]
    public required string UnitCode { get; set; }

    [JsonPropertyName("factor")]
    public required string Factor { get; set; }

    [JsonPropertyName("isDefaultSale")]
    public required bool IsDefaultSale { get; set; }

    [JsonPropertyName("isDefaultPurchase")]
    public required bool IsDefaultPurchase { get; set; }

    [JsonPropertyName("salePriceExclVat")]
    public string? SalePriceExclVat { get; set; }

    [JsonPropertyName("purchasePriceExclVat")]
    public string? PurchasePriceExclVat { get; set; }

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
