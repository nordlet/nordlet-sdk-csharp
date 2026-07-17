using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatComputeResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemNumber")]
    public required long ItemNumber { get; set; }

    [JsonPropertyName("cnCode")]
    public required string CnCode { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("transactionNature")]
    public required string TransactionNature { get; set; }

    [JsonPropertyName("deliveryTerms")]
    public string? DeliveryTerms { get; set; }

    [JsonPropertyName("transportMode")]
    public string? TransportMode { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("originCountry")]
    public string? OriginCountry { get; set; }

    [JsonPropertyName("partnerVat")]
    public string? PartnerVat { get; set; }

    [JsonPropertyName("netMassKg")]
    public required string NetMassKg { get; set; }

    [JsonPropertyName("supplementaryUnit")]
    public string? SupplementaryUnit { get; set; }

    [JsonPropertyName("supplementaryQty")]
    public string? SupplementaryQty { get; set; }

    [JsonPropertyName("invoicedValue")]
    public required string InvoicedValue { get; set; }

    [JsonPropertyName("statisticalValue")]
    public required string StatisticalValue { get; set; }

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
