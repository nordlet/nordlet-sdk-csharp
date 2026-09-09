using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CatalogItemsGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1CatalogItemsGetResponseType Type { get; set; }

    [JsonPropertyName("tracking")]
    public required PostV1CatalogItemsGetResponseTracking Tracking { get; set; }

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

    [JsonPropertyName("documentRef")]
    public string? DocumentRef { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<
        string,
        PostV1CatalogItemsGetResponseTranslationsValue?
    >? Translations { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1CatalogItemsGetResponseComponentsItem> Components { get; set; } =
        new List<PostV1CatalogItemsGetResponseComponentsItem>();

    [JsonPropertyName("kindId")]
    public string? KindId { get; set; }

    [JsonPropertyName("saleAccountCode")]
    public string? SaleAccountCode { get; set; }

    [JsonPropertyName("purchaseAccountCode")]
    public string? PurchaseAccountCode { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public string? ExpenseAccountCode { get; set; }

    [JsonPropertyName("manufacturer")]
    public string? Manufacturer { get; set; }

    [JsonPropertyName("grossMassKg")]
    public string? GrossMassKg { get; set; }

    [JsonPropertyName("minQuantity")]
    public string? MinQuantity { get; set; }

    [JsonPropertyName("costPrice")]
    public string? CostPrice { get; set; }

    [JsonPropertyName("isFreePrice")]
    public required bool IsFreePrice { get; set; }

    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    [JsonPropertyName("isReturnable")]
    public required bool IsReturnable { get; set; }

    [JsonPropertyName("commentRequired")]
    public required bool CommentRequired { get; set; }

    [JsonPropertyName("priceFrom")]
    public string? PriceFrom { get; set; }

    [JsonPropertyName("priceTo")]
    public string? PriceTo { get; set; }

    [JsonPropertyName("minPrice")]
    public string? MinPrice { get; set; }

    [JsonPropertyName("discountPercent")]
    public string? DiscountPercent { get; set; }

    [JsonPropertyName("maxDiscountPercent")]
    public string? MaxDiscountPercent { get; set; }

    [JsonPropertyName("loyaltyPoints")]
    public long? LoyaltyPoints { get; set; }

    [JsonPropertyName("department")]
    public string? Department { get; set; }

    [JsonPropertyName("ageRestriction")]
    public long? AgeRestriction { get; set; }

    [JsonPropertyName("packageQuantity")]
    public string? PackageQuantity { get; set; }

    [JsonPropertyName("taraCode")]
    public string? TaraCode { get; set; }

    [JsonPropertyName("certificateNumber")]
    public string? CertificateNumber { get; set; }

    [JsonPropertyName("certificateDate")]
    public string? CertificateDate { get; set; }

    [JsonPropertyName("validFrom")]
    public string? ValidFrom { get; set; }

    [JsonPropertyName("validTo")]
    public string? ValidTo { get; set; }

    [JsonPropertyName("posFlags")]
    public Dictionary<string, bool?>? PosFlags { get; set; }

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
