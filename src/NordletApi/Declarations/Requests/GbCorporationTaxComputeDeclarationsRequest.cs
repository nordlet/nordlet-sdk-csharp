using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbCorporationTaxComputeDeclarationsRequest
{
    [JsonPropertyName("periodStart")]
    public required DateOnly PeriodStart { get; set; }

    [JsonPropertyName("periodEnd")]
    public required DateOnly PeriodEnd { get; set; }

    [JsonPropertyName("taxableTotalProfits")]
    public required string TaxableTotalProfits { get; set; }

    [JsonPropertyName("exemptDistributions")]
    public string? ExemptDistributions { get; set; }

    [JsonPropertyName("associatedCompanies")]
    public long? AssociatedCompanies { get; set; }

    [JsonPropertyName("closeInvestmentHolding")]
    public bool? CloseInvestmentHolding { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
