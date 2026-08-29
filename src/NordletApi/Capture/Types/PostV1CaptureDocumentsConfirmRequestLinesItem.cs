using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;
using OneOf;

namespace NordletApi;

[Serializable]
public record PostV1CaptureDocumentsConfirmRequestLinesItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemId")]
    public string? ItemId { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    [JsonPropertyName("quantity")]
    public OneOf<double, string>? Quantity { get; set; }

    [JsonPropertyName("unitPriceExclVat")]
    public string? UnitPriceExclVat { get; set; }

    [JsonPropertyName("unitPriceInclVat")]
    public string? UnitPriceInclVat { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public string? VatRatePercent { get; set; }

    [JsonPropertyName("vatClassifierCode")]
    public string? VatClassifierCode { get; set; }

    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; set; }

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
