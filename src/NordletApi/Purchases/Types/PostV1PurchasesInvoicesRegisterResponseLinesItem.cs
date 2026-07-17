using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PurchasesInvoicesRegisterResponseLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    [JsonPropertyName("unit")]
    public required string Unit { get; set; }

    [JsonPropertyName("quantity")]
    public required string Quantity { get; set; }

    [JsonPropertyName("unitPriceExclVat")]
    public string? UnitPriceExclVat { get; set; }

    [JsonPropertyName("unitPriceInclVat")]
    public string? UnitPriceInclVat { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public required string VatRatePercent { get; set; }

    [JsonPropertyName("vatClassifierCode")]
    public string? VatClassifierCode { get; set; }

    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; set; }

    [JsonPropertyName("lineNet")]
    public required string LineNet { get; set; }

    [JsonPropertyName("lineVat")]
    public required string LineVat { get; set; }

    [JsonPropertyName("lineGross")]
    public required string LineGross { get; set; }

    [JsonPropertyName("sortOrder")]
    public required long SortOrder { get; set; }

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
