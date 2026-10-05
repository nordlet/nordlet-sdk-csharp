using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TaxPaymentsCreateDeclarationsRequest
{
    [JsonPropertyName("tax")]
    public required TaxPaymentsCreateDeclarationsRequestTax Tax { get; set; }

    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public long? Month { get; set; }

    [JsonPropertyName("kind")]
    public required TaxPaymentsCreateDeclarationsRequestKind Kind { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("paidOn")]
    public required DateOnly PaidOn { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }

    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
