using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbReturnFactsSetDeclarationsResponseFacts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("companyType")]
    public long? CompanyType { get; set; }

    [JsonPropertyName("associatedCompanies")]
    public long? AssociatedCompanies { get; set; }

    [JsonPropertyName("partnerInFirm")]
    public bool? PartnerInFirm { get; set; }

    [JsonPropertyName("smallCompaniesRegime")]
    public bool? SmallCompaniesRegime { get; set; }

    [JsonPropertyName("auditExemptionSection477")]
    public bool? AuditExemptionSection477 { get; set; }

    [JsonPropertyName("depreciation")]
    public string? Depreciation { get; set; }

    [JsonPropertyName("amortisation")]
    public string? Amortisation { get; set; }

    [JsonPropertyName("lossOrProfitOnSale")]
    public string? LossOrProfitOnSale { get; set; }

    [JsonPropertyName("entertaining")]
    public string? Entertaining { get; set; }

    [JsonPropertyName("otherAdditions")]
    public string? OtherAdditions { get; set; }

    [JsonPropertyName("nonTradingLoanCredits")]
    public string? NonTradingLoanCredits { get; set; }

    [JsonPropertyName("nonTradingLoanDebits")]
    public string? NonTradingLoanDebits { get; set; }

    [JsonPropertyName("nonTaxableIncome")]
    public string? NonTaxableIncome { get; set; }

    [JsonPropertyName("exemptDistributions")]
    public string? ExemptDistributions { get; set; }

    [JsonPropertyName("capitalAllowances")]
    public GbReturnFactsSetDeclarationsResponseFactsCapitalAllowances? CapitalAllowances { get; set; }

    [JsonPropertyName("balancingCharges")]
    public GbReturnFactsSetDeclarationsResponseFactsBalancingCharges? BalancingCharges { get; set; }

    [JsonPropertyName("tradingLossesBroughtForward")]
    public string? TradingLossesBroughtForward { get; set; }

    [JsonPropertyName("grossChargeableGains")]
    public string? GrossChargeableGains { get; set; }

    [JsonPropertyName("allowableLosses")]
    public string? AllowableLosses { get; set; }

    [JsonPropertyName("qualifyingDonations")]
    public string? QualifyingDonations { get; set; }

    [JsonPropertyName("taxAlreadyPaid")]
    public string? TaxAlreadyPaid { get; set; }

    [JsonPropertyName("declarantName")]
    public string? DeclarantName { get; set; }

    [JsonPropertyName("declarantStatus")]
    public string? DeclarantStatus { get; set; }

    [JsonPropertyName("seniorStatutoryAuditor")]
    public string? SeniorStatutoryAuditor { get; set; }

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
