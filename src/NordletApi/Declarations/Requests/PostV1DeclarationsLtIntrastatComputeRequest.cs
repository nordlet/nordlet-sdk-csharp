using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIntrastatComputeRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("flow")]
    public required PostV1DeclarationsLtIntrastatComputeRequestFlow Flow { get; set; }

    [JsonPropertyName("transactionNature")]
    public string? TransactionNature { get; set; }

    [JsonPropertyName("deliveryTerms")]
    public string? DeliveryTerms { get; set; }

    [JsonPropertyName("transportMode")]
    public PostV1DeclarationsLtIntrastatComputeRequestTransportMode? TransportMode { get; set; }

    [JsonPropertyName("regionCode")]
    public string? RegionCode { get; set; }

    [JsonPropertyName("statisticalValueRequired")]
    public bool? StatisticalValueRequired { get; set; }

    [JsonPropertyName("preparationTimeHours")]
    public long? PreparationTimeHours { get; set; }

    [JsonPropertyName("preparationTimeMinutes")]
    public long? PreparationTimeMinutes { get; set; }

    [JsonPropertyName("persist")]
    public bool? Persist { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
