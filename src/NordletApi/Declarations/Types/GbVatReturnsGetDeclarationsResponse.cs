using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatReturnsGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodKey")]
    public required string PeriodKey { get; set; }

    [JsonPropertyName("vatDueSales")]
    public required double VatDueSales { get; set; }

    [JsonPropertyName("vatDueAcquisitions")]
    public required double VatDueAcquisitions { get; set; }

    [JsonPropertyName("totalVatDue")]
    public required double TotalVatDue { get; set; }

    [JsonPropertyName("vatReclaimedCurrPeriod")]
    public required double VatReclaimedCurrPeriod { get; set; }

    [JsonPropertyName("netVatDue")]
    public required double NetVatDue { get; set; }

    [JsonPropertyName("totalValueSalesExVAT")]
    public required double TotalValueSalesExVat { get; set; }

    [JsonPropertyName("totalValuePurchasesExVAT")]
    public required double TotalValuePurchasesExVat { get; set; }

    [JsonPropertyName("totalValueGoodsSuppliedExVAT")]
    public required double TotalValueGoodsSuppliedExVat { get; set; }

    [JsonPropertyName("totalAcquisitionsExVAT")]
    public required double TotalAcquisitionsExVat { get; set; }

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
