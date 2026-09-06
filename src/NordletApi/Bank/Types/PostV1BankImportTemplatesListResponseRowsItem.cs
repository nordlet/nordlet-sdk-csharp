using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankImportTemplatesListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("type")]
    public required PostV1BankImportTemplatesListResponseRowsItemType Type { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1BankImportTemplatesListResponseRowsItemFieldsItem> Fields { get; set; } =
        new List<PostV1BankImportTemplatesListResponseRowsItemFieldsItem>();

    [JsonPropertyName("metaFields")]
    public IEnumerable<string> MetaFields { get; set; } = new List<string>();

    [JsonPropertyName("invoiceMetaField")]
    public string? InvoiceMetaField { get; set; }

    [JsonPropertyName("invoiceVatRatePercent")]
    public string? InvoiceVatRatePercent { get; set; }

    [JsonPropertyName("companyMetaField")]
    public string? CompanyMetaField { get; set; }

    [JsonPropertyName("invoiceItemId")]
    public string? InvoiceItemId { get; set; }

    [JsonPropertyName("advanceInvoices")]
    public required bool AdvanceInvoices { get; set; }

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
