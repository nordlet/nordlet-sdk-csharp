using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsUpdateRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public PostV1CatalogItemsUpdateRequestType? Type { get; set; }

    [JsonPropertyName("tracking")]
    public PostV1CatalogItemsUpdateRequestTracking? Tracking { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

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
    public Dictionary<string, string>? Attributes { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<
        string,
        PostV1CatalogItemsUpdateRequestTranslationsValue
    >? Translations { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1CatalogItemsUpdateRequestComponentsItem>? Components { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
