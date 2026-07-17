using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1EcommerceProductsListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1EcommerceProductsListResponseRowsItemType Type { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("barcode")]
    public string? Barcode { get; set; }

    [JsonPropertyName("unit")]
    public required string Unit { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("translations")]
    public Dictionary<
        string,
        PostV1EcommerceProductsListResponseRowsItemTranslationsValue?
    >? Translations { get; set; }

    [JsonPropertyName("attributes")]
    public Dictionary<string, string?>? Attributes { get; set; }

    [JsonPropertyName("groupId")]
    public string? GroupId { get; set; }

    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("price")]
    public string? Price { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("components")]
    public IEnumerable<PostV1EcommerceProductsListResponseRowsItemComponentsItem> Components { get; set; } =
        new List<PostV1EcommerceProductsListResponseRowsItemComponentsItem>();

    [JsonPropertyName("onHand")]
    public string? OnHand { get; set; }

    [JsonPropertyName("reserved")]
    public string? Reserved { get; set; }

    [JsonPropertyName("available")]
    public string? Available { get; set; }

    [JsonPropertyName("deleted")]
    public required bool Deleted { get; set; }

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
