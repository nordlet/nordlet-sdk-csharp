using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1CatalogItemsListResponseRowsItemType Type { get; set; }

    [JsonPropertyName("tracking")]
    public required PostV1CatalogItemsListResponseRowsItemTracking Tracking { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("unit")]
    public required string Unit { get; set; }

    [JsonPropertyName("vatClassifierCode")]
    public string? VatClassifierCode { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("salePriceExclVat")]
    public string? SalePriceExclVat { get; set; }

    [JsonPropertyName("purchasePriceExclVat")]
    public string? PurchasePriceExclVat { get; set; }

    [JsonPropertyName("cnCode")]
    public string? CnCode { get; set; }

    [JsonPropertyName("originCountry")]
    public string? OriginCountry { get; set; }

    [JsonPropertyName("netMassKg")]
    public string? NetMassKg { get; set; }

    [JsonPropertyName("supplementaryUnit")]
    public string? SupplementaryUnit { get; set; }

    [JsonPropertyName("supplementaryQtyPerUnit")]
    public string? SupplementaryQtyPerUnit { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("attributes")]
    public Dictionary<string, string?>? Attributes { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<
        string,
        PostV1CatalogItemsListResponseRowsItemTranslationsValue?
    >? Translations { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1CatalogItemsListResponseRowsItemComponentsItem> Components { get; set; } =
        new List<PostV1CatalogItemsListResponseRowsItemComponentsItem>();

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

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
